using LL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Championship_DAOs_classes
{
    public class ChampionshipDAO : ICampionshipDAO
    {
        public bool AddChampionship(Championship championship)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_championship (season, winner, constructorwinner) VALUES (@season, @winner, @constructorwinner)", conn);

                    cmd.Parameters.AddWithValue("@season", championship.Season);
                    cmd.Parameters.AddWithValue("@winner", championship.Winner);
                    cmd.Parameters.AddWithValue("@constructorwinner", championship.ConstructorWinner);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteChampionship(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_championship WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ChampionshipDTO GetChampionship(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM f1_championship WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ChampionshipDTO championship = new ChampionshipDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Season = reader.GetDateOnly("season"),
                                Winner = reader.IsDBNull(reader.GetOrdinal("winner")) ? (int?)null : Convert.ToInt32(reader["winner"]),
                                ConstructorWinner = reader.IsDBNull(reader.GetOrdinal("constructorwinner")) ? (int?)null : Convert.ToInt32(reader["constructorwinner"])
                            };
                            return championship;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ChampionshipDTO> GetChampionships()
        {
            List<ChampionshipDTO> championships = new List<ChampionshipDTO>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM f1_championship", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChampionshipDTO championship = new ChampionshipDTO
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Season = reader.GetDateOnly("season"),
                                Winner = reader.IsDBNull(reader.GetOrdinal("winner")) ? (int?)null : Convert.ToInt32(reader["winner"]),
                                ConstructorWinner = reader.IsDBNull(reader.GetOrdinal("constructorwinner")) ? (int?)null : Convert.ToInt32(reader["constructorwinner"])
                            };
                            championships.Add(championship);
                        }
                    }
                }
                return championships;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateChampionship(Championship championship)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_championship SET season = @season, winner = @winner, constructorwinner = @constructorwinner WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", championship.ID);
                    cmd.Parameters.AddWithValue("@season", championship.Season);
                    cmd.Parameters.AddWithValue("@winner", championship.Winner);
                    cmd.Parameters.AddWithValue("@constructorwinner", championship.ConstructorWinner);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
