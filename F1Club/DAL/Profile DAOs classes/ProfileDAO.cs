using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LL;
using static LL.Profile_related.ProfileManager;
using static LL.Exceptions;

namespace DAL
{
    public class ProfileDAO : IProfileDAO
    {
        private int lastInsertedId;

        public void ChangePassword(string passwordNew,  int id)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_profile SET password = @passwordNew WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@passwordNew", passwordNew);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
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

        public void CreateProfile(Profile Profile)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO f1_profile (email, password, firstname, lastname, dateofbirth, phonenumber, usertype) VALUES (@email, @password, @firstname, @lastname, @dateofbirth, @phonenumber, @usertype); SELECT LAST_INSERT_ID();", conn);
                    cmd.Parameters.AddWithValue("@email", Profile.Email);
                    cmd.Parameters.AddWithValue("@password", Profile.Password);
                    cmd.Parameters.AddWithValue("@firstname", Profile.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", Profile.LastName);
                    cmd.Parameters.AddWithValue("@dateofbirth", Profile.DateOfBirth);
                    cmd.Parameters.AddWithValue("@phonenumber", Profile.PhoneNumber);
                    cmd.Parameters.AddWithValue("@usertype", (int)Profile.UserType);

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


        public void DeleteProfile(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM f1_profile WHERE id = @id", conn);
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

        public List<Profile> GetAllProfiles()
        {
            List<Profile> profiles = new List<Profile>();
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM f1_profile", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Profile profile = new Profile
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Email = reader.GetString("email"),
                                Password = reader.GetString("password"),
                                FirstName = reader.GetString("firstname"),
                                LastName = reader.GetString("lastname"),
                                DateOfBirth = reader.GetDateOnly("dateofbirth"),
                                PhoneNumber = reader.GetString("phonenumber"),
                                UserType = (UserType)reader.GetInt32("usertype")
                            };
                            profiles.Add(profile);
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
            return profiles;
        }

        public Profile Login(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM f1_profile WHERE email = @email", conn);
                    cmd.Parameters.AddWithValue("@email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Profile profile = new Profile
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Email = email,
                                Password = reader.GetString("password"),
                                FirstName = reader.GetString("firstname"),
                                LastName = reader.GetString("lastname"),
                                DateOfBirth = reader.GetDateOnly("dateofbirth"),
                                PhoneNumber = reader.GetString("phonenumber"),
                                UserType = (UserType)reader.GetInt32("usertype")
                            };
                            return profile;
                        }
                        else
                        {
                            return null;
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
        }

		public bool ProfileExistsByEmail(string email)
		{
			using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
			{
				try
				{
					conn.Open();
					MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM f1_profile WHERE email = @email", conn);
					cmd.Parameters.AddWithValue("@email", email);
					var result = Convert.ToInt32(cmd.ExecuteScalar());
					return result > 0;
				}
				catch (MySqlException ex)
				{
                    if (ex.Number == (int)MySqlErrorCode.UnableToConnectToHost)
                    {
						throw new DatabaseNotAccessibleException("The database is currently down. We are sorry for the inconvenience!");
					}
					return false;
				}
			}
		}

		public void UpdateProfile(Profile Profile)
        {
            using (MySqlConnection conn = new MySqlConnection(IConnection.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE f1_profile SET email = @email, firstname = @firstname, lastname = @lastname, dateofbirth = @dateofbirth, phonenumber = @phonenumber, usertype = @usertype WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@id", Profile.ID);
                    cmd.Parameters.AddWithValue("@email", Profile.Email);
                    cmd.Parameters.AddWithValue("@firstname", Profile.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", Profile.LastName);
                    cmd.Parameters.AddWithValue("@dateofbirth", Profile.DateOfBirth);
                    cmd.Parameters.AddWithValue("@phonenumber", Profile.PhoneNumber);
                    cmd.Parameters.AddWithValue("@usertype", (int)Profile.UserType);

                    int rowsAffected = cmd.ExecuteNonQuery();
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
