using LL;
using LL.Team_related;
using MySqlConnector;
using System;
using System.Collections.Generic;
using static LL.Exceptions;

namespace DAL.Car_DAOs_classes
{
    public class CarDAO : ICarDAO
    {
        private int lastInsertedId;

        public void AddCar(Car car)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_car (id, team, seasonused, chassis, engine, handlingscore, accelerationscore, breakingscore, topspeedpossible) VALUES (@id, @team, @seasonused, @chassis, @engine, @handlingscore, @accelerationscore, @breakingscore, @topspeedpossible); SELECT LAST_INSERT_ID();", conn);

                    cmd.Parameters.AddWithValue("@id", car.ID);
                    cmd.Parameters.AddWithValue("@team", car.Team.ID);
                    cmd.Parameters.AddWithValue("@seasonused", car.SeasonUsed);
                    cmd.Parameters.AddWithValue("@chassis", car.Chassis);
                    cmd.Parameters.AddWithValue("@engine", car.Engine);
                    cmd.Parameters.AddWithValue("@handlingscore", car.HandlingScore);
                    cmd.Parameters.AddWithValue("@accelerationscore", car.AccelerationScore);
                    cmd.Parameters.AddWithValue("@breakingscore", car.BreakingScore);
                    cmd.Parameters.AddWithValue("@topspeedpossible", car.TopSpeedPossible);

                    this.lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == (int)MySqlErrorCode.UnableToConnectToHost)
                    {
                        throw new DatabaseNotAccessibleException("The database is currently down. We are sorry for the inconvenience!");
                    }
                    else if (ex.Number == (int)MySqlErrorCode.DataTooLong)
                    {
                        throw new DataLengthException("Data length exceeds the limit.");
                    }
                }
            }
        }

        public int GetLastInsertedId()
        {
            return this.lastInsertedId;
        }

        public void DeleteCar(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_car WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == (int)MySqlErrorCode.UnableToConnectToHost)
                    {
                        throw new DatabaseNotAccessibleException("The database is currently down. We are sorry for the inconvenience!");
                    }
                }
            }
        }

        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT f1_car.*, f1_team.name as teamName, f1_team.creationdate as teamCreationDate FROM f1_car INNER JOIN f1_team ON f1_car.team = f1_team.id", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Team team = new Team
                            {
                                ID = Convert.ToInt32(reader["team"]),
                                Name = reader.GetString("teamName"),
                                CreationDate = reader.GetDateOnly("teamCreationDate")
                            };
                            Car car = new Car(
                                                    Convert.ToInt32(reader["id"]),
                                                    team,
                                                    reader.GetDateOnly("seasonused"),
                                                    reader.GetString("chassis"),
                                                    reader.GetString("engine"),
                                                    reader.GetDouble("handlingscore"),
                                                    reader.GetDouble("accelerationscore"),
                                                    reader.GetDouble("breakingscore"),
                                                    reader.GetInt32("topspeedpossible")
                                                );
                            cars.Add(car);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == (int)MySqlErrorCode.UnableToConnectToHost)
                    {
                        throw new DatabaseNotAccessibleException("The database is currently down. We are sorry for the inconvenience!");
                    }
                    return null;
                }
            }
            return cars;
        }




        public void UpdateCar(Car car)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_car SET team = @team, seasonused=@seasonused, chassis = @chassis, engine = @engine, handlingscore = @handlingscore, accelerationscore = @accelerationscore, breakingscore = @breakingscore, topspeedpossible = @topspeedpossible WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", car.ID);
                    cmd.Parameters.AddWithValue("@team", car.Team.ID);
                    cmd.Parameters.AddWithValue("@seasonused", car.SeasonUsed);
                    cmd.Parameters.AddWithValue("@chassis", car.Chassis);
                    cmd.Parameters.AddWithValue("@engine", car.Engine);
                    cmd.Parameters.AddWithValue("@handlingscore", car.HandlingScore);
                    cmd.Parameters.AddWithValue("@accelerationscore", car.AccelerationScore);
                    cmd.Parameters.AddWithValue("@breakingscore", car.BreakingScore);
                    cmd.Parameters.AddWithValue("@topspeedpossible", car.TopSpeedPossible);

                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == (int)MySqlErrorCode.UnableToConnectToHost)
                    {
                        throw new DatabaseNotAccessibleException("The database is currently down. We are sorry for the inconvenience!");
                    }
                    else if (ex.Number == (int)MySqlErrorCode.DataTooLong)
                    {
                        throw new DataLengthException("Data length exceeds the limit.");
                    }
                }
            }
        }
    }
}
