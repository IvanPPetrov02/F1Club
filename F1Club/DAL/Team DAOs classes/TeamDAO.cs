using LL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace DAL.Team_DAOs_classes
{
    public class TeamDAO : ITeamDAO
    {
        private int lastInsertedId;

        public void CreateTeam(Team team)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_team (name, creationdate) VALUES (@name, @creationdate); SELECT LAST_INSERT_ID();", conn);

                    cmd.Parameters.AddWithValue("@name", team.Name);
                    cmd.Parameters.AddWithValue("@creationdate", team.CreationDate);

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

        public void DeleteTeam(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_team WHERE id = @id", conn);
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

        public List<Team> GetAllTeams()
        {
            List<Team> teams = new List<Team>();
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM f1_team", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Team team = new Team
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Name = reader.GetString("name"),
                                CreationDate = reader.GetDateOnly("creationdate")
                            };
                            teams.Add(team);
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
            return teams;
        }

        public int GetLastInsertedId()
        {
            return this.lastInsertedId; 
        }

        public void UpdateTeam(Team team)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_team SET name = @name, creationdate = @creationdate WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", team.ID);
                    cmd.Parameters.AddWithValue("@name", team.Name);
                    cmd.Parameters.AddWithValue("@creationdate", team.CreationDate);

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
