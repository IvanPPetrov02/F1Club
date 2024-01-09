using LL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static LL.Exceptions;

namespace DAL
{
    public class GPResultDAO : IGPResultDAO
    {
        public void DeleteGPResult(int gpid, int driverid)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_gpresults WHERE gpid = @gpid AND driverid = @driverid", conn);
                    cmd.Parameters.AddWithValue("@gpid", gpid);
                    cmd.Parameters.AddWithValue("@driverid", driverid);

                    cmd.ExecuteNonQuery();
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

        public List<GPResult> GetAllGPResults()
        {
            List<GPResult> gpResults = new List<GPResult>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT gr.timetofinish, gr.maxspeed, gr.avgspeed, gr.laptime, gr.position, gp.id AS gp_id, gp.dateofgp, d.id AS driver_id, d.number, d.firstname, d.lastname, d.dateofbirth, " +
                        "t.id AS team_id, t.name AS team_name, t.engine, t.creationdate AS creation_date, " +
                        "c.id AS circuit_id, c.name AS circuit_name, c.numberoflaps, c.length " +
                        "FROM f1_gpresults gr " +
                        "INNER JOIN f1_gp gp ON gr.gpid = gp.id " +
                        "INNER JOIN f1_driver d ON gr.driverid = d.id " +
                        "INNER JOIN f1_team t ON d.team = t.id " +
                        "INNER JOIN f1_circuit c ON gp.circuit = c.id", conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GPResult gpResult = new GPResult
                            {
                                GP = new GP
                                {
                                    ID = Convert.ToInt32(reader["gp_id"]),
                                    DateOfGP = reader.GetDateOnly("dateofgp"),
                                    Circuit = new Circuit
                                    {
                                        ID = Convert.ToInt32(reader["circuit_id"]),
                                        Name = reader.GetString("circuit_name"),
                                        NumberOfLaps = Convert.ToInt32(reader["numberoflaps"]),
                                        Length = Convert.ToInt32(reader["length"])
                                    }
                                },
                                Driver = new Driver
                                {
                                    ID = Convert.ToInt32(reader["driver_id"]),
                                    Number = Convert.ToInt32(reader["number"]),
                                    FirstName = reader.GetString("firstname"),
                                    LastName = reader.GetString("lastname"),
                                    DateOfBirth = reader.GetDateOnly("dateofbirth"),
                                    Team = new Team
                                    {
                                        ID = Convert.ToInt32(reader["team_id"]),
                                        Name = reader.GetString("team_name"),
                                        CreationDate = reader.GetDateOnly("creation_date")
                                    }
                                },
                                Place = Convert.ToInt32(reader["position"]),
                                LapTime = TimeSpan.FromMilliseconds(reader.GetInt32("laptime")),
                                FinishTime = TimeSpan.FromMilliseconds(reader.GetInt32("timetofinish")),
                                MaxSpeed = reader.GetInt32("maxspeed"),
                                AvgSpeed = reader.GetInt32("avgspeed"),
                            };

                            gpResults.Add(gpResult);
                        }
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
            return gpResults;
        }

        public void SetGPResult(GPResult gpResult)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_gpresults (gpid, driverid, position, laptime, timetofinish, maxspeed, avgspeed) VALUES (@gpid, @driverid, @position, @laptime, @timetofinish, @maxspeed, @avgspeed)", conn);

                    cmd.Parameters.AddWithValue("@gpid", gpResult.GP.ID);
                    cmd.Parameters.AddWithValue("@driverid", gpResult.Driver.ID);
                    cmd.Parameters.AddWithValue("@position", gpResult.Place);
                    cmd.Parameters.AddWithValue("@laptime", gpResult.LapTime.TotalMilliseconds);
                    cmd.Parameters.AddWithValue("@timetofinish", gpResult.FinishTime.TotalMilliseconds);
                    cmd.Parameters.AddWithValue("@maxspeed", gpResult.MaxSpeed);
                    cmd.Parameters.AddWithValue("@avgspeed", gpResult.AvgSpeed);

                    cmd.ExecuteNonQuery();
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

        public void UpdateGPResult(GPResult gpResult)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_gpresults SET position = @position, laptime=@laptime, timetofinish=@timetofinish, maxspeed=@maxspeed, avgspeed=@avgspeed WHERE gpid = @gpid AND driverid = @driverid", conn);

                    cmd.Parameters.AddWithValue("@gpid", gpResult.GP.ID);
                    cmd.Parameters.AddWithValue("@driverid", gpResult.Driver.ID);
                    cmd.Parameters.AddWithValue("@position", gpResult.Place);
                    cmd.Parameters.AddWithValue("@laptime", gpResult.LapTime.TotalMilliseconds);
                    cmd.Parameters.AddWithValue("@timetofinish", gpResult.FinishTime.TotalMilliseconds);
                    cmd.Parameters.AddWithValue("@maxspeed", gpResult.MaxSpeed);
                    cmd.Parameters.AddWithValue("@avgspeed", gpResult.AvgSpeed);

                    cmd.ExecuteNonQuery();
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
    }
}
