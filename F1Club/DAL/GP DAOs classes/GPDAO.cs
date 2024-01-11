using LL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LL.Exceptions;

namespace DAL.GP_DAOs_classes
{
    public class GPDAO : IGPDAO
    {
        private int lastInsertedId;

        public void CreateGP(GP gp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_gp (circuit, dateofgp) VALUES (@circuit, @dateofgp); SELECT LAST_INSERT_ID();", conn);

                    cmd.Parameters.AddWithValue("@circuit", gp.Circuit.ID);
                    cmd.Parameters.AddWithValue("@dateofgp", gp.DateOfGP);

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

        public void DeleteGP(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_gp WHERE id = @id", conn);
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
            }
        }

        public List<GP> GetAllGPs()
        {
            List<GP> gps = new List<GP>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT f1_gp.id as gp_id, f1_gp.circuit as circuit_id, f1_gp.dateofgp, f1_circuit.name, f1_circuit.numberoflaps, f1_circuit.length FROM f1_gp LEFT JOIN f1_circuit ON f1_gp.circuit = f1_circuit.id", conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Circuit circuit = new Circuit
                            {
                                ID = Convert.ToInt32(reader["circuit_id"]),
                                Name = reader.GetString("name"),
                                NumberOfLaps = Convert.ToInt32(reader["numberoflaps"]),
                                Length = Convert.ToDouble(reader["length"])
                            };

                            GP gp = new GP
                            {
                                ID = Convert.ToInt32(reader["gp_id"]),
                                Circuit = circuit,
                                DateOfGP = reader.GetDateOnly("dateofgp")
                            };
                            gps.Add(gp);
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
            return gps;
        }

        public void UpdateGP(GP gp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_gp SET circuit = @circuit, dateofgp = @dateofgp WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", gp.ID);
                    cmd.Parameters.AddWithValue("@circuit", gp.Circuit.ID);
                    cmd.Parameters.AddWithValue("@dateofgp", gp.DateOfGP);

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
