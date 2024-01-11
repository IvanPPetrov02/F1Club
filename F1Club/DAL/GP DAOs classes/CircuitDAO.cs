using LL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace DAL.GP_DAOs_classes
{
    public class CircuitDAO : ICircuitDAO
    {
        private int lastInsertedId;

        public void CreateCircuit(Circuit circuit)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_circuit (name, numberoflaps, length, numberofcorners, roadscore) VALUES (@name, @numberoflaps, @length, @numberofcorners, @roadscore); SELECT LAST_INSERT_ID();", conn);

                    cmd.Parameters.AddWithValue("@name", circuit.Name);
                    cmd.Parameters.AddWithValue("@numberoflaps", circuit.NumberOfLaps);
                    cmd.Parameters.AddWithValue("@length", circuit.Length);
                    cmd.Parameters.AddWithValue("@numberofcorners", circuit.NumberOfCorners);
                    cmd.Parameters.AddWithValue("@roadscore", circuit.RoadScore);

                    this.lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                }
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

        public int GetLastInsertedId()
        {
            return this.lastInsertedId;
        }

        public void DeleteCircuit(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_circuit WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    cmd.ExecuteNonQuery();
                }
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

        public List<Circuit> GetCircuits()
        {
            List<Circuit> circuits = new List<Circuit>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM f1_circuit", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Circuit circuit = new Circuit
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader.GetString("name"),
                                NumberOfLaps = Convert.ToInt32(reader["numberoflaps"]),
                                Length = Convert.ToDouble(reader["length"]),
                                NumberOfCorners = Convert.ToInt32(reader["numberofcorners"]),
                                RoadScore = Convert.ToDouble(reader["roadscore"])
                            };
                            circuits.Add(circuit);
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
            return circuits;
        }

        public void UpdateCircuit(Circuit circuit)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_circuit SET name = @name, numberoflaps = @numberoflaps, length = @length, numberofcorners = @numberofcorners, roadscore = @roadscore WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", circuit.ID);
                    cmd.Parameters.AddWithValue("@name", circuit.Name);
                    cmd.Parameters.AddWithValue("@numberoflaps", circuit.NumberOfLaps);
                    cmd.Parameters.AddWithValue("@length", circuit.Length);
                    cmd.Parameters.AddWithValue("@numberofcorners", circuit.NumberOfCorners);
                    cmd.Parameters.AddWithValue("@roadscore", circuit.RoadScore);

                    cmd.ExecuteNonQuery();
                }
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
