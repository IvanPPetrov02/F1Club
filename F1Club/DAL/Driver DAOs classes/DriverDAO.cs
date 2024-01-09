using LL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace DAL.Driver_DAOs_classes
{
    public class DriverDAO : IDriverDAO
    {
        private int lastInsertedId;

        public void CreateDriver(Driver driver)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_driver (number, firstname, lastname, dateofbirth, team) VALUES (@number, @firstname, @lastname, @dateofbirth, @team); SELECT LAST_INSERT_ID();", conn);

                    cmd.Parameters.AddWithValue("@number", driver.Number);
                    cmd.Parameters.AddWithValue("@firstname", driver.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", driver.LastName);
                    cmd.Parameters.AddWithValue("@dateofbirth", driver.DateOfBirth);
                    cmd.Parameters.AddWithValue("@team", driver.Team.ID);

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

        public void DeleteDriver(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_driver WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
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

        public List<Driver> GetAllDrivers()
        {
            List<Driver> drivers = new List<Driver>();
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT driver.id AS driver_id, driver.number, driver.firstname, driver.lastname, driver.dateofbirth, team.id AS team_id, team.name , team.engine, team.creationdate " +
                                                        "FROM f1_driver driver " +
                                                        "INNER JOIN f1_team team ON driver.team = team.id", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Driver driver = new Driver
                            {
                                ID = Convert.ToInt32(reader["driver_id"]),
                                Number = Convert.ToInt32(reader["number"]),
                                FirstName = reader.GetString("firstname"),
                                LastName = reader.GetString("lastname"),
                                DateOfBirth = reader.GetDateOnly("dateofbirth"),
                                Team = new Team
                                {
                                    ID = Convert.ToInt32(reader["team_id"]),
                                    Name = reader.GetString("name"),
                                    CreationDate = reader.GetDateOnly("creationdate")
                                }
                            };
                            drivers.Add(driver);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == (int)MySqlErrorCode.UnableToConnectToHost)
                    {
                        throw new DatabaseNotAccessibleException("The database is currently down. We are sorry for the inconvenience!");
                    }
                }
            }
            return drivers;
        }

        public int GetLastID()
        {
            return this.lastInsertedId;
        }

        public void UpdateDriver(Driver driver)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_driver SET number = @number, firstname = @firstname, lastname = @lastname, dateofbirth = @dateofbirth, team = @team WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", driver.ID);
                    cmd.Parameters.AddWithValue("@number", driver.Number);
                    cmd.Parameters.AddWithValue("@firstname", driver.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", driver.LastName);
                    cmd.Parameters.AddWithValue("@dateofbirth", driver.DateOfBirth);
                    cmd.Parameters.AddWithValue("@team", driver.Team.ID);
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
