using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class PrfoileDAOFake : IProfileDAO
    {
        List<Profile> profiles = new List<Profile>();

        public bool ChangePassword(string passwordNew, string passwordCurrent, int id)
        {
            throw new NotImplementedException();
        }

        public void CreateProfile(Profile Profile)
        {
            profiles.Add(Profile);
        }

        public bool DeleteProfile(int id)
        {
            throw new NotImplementedException();
        }

        public List<Profile> GetAllProfiles()
        {
            return profiles;
        }

        public List<Profile> GetAllUsersByUserType(UserType userType)
        {
            throw new NotImplementedException();
        }

        public int GetLastID()
        {
            return profiles.Count;
        }

        public Profile Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool ProfileExistsByEmail(string email)
        {
            return profiles.Any(p => p.Email == email);
        }

        public bool UpdateProfile(Profile Profile)
        {
            throw new NotImplementedException();
        }
    }
}
