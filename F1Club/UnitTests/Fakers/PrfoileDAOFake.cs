using LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Fakers
{
    public class ProfileDAOFake : IProfileDAO
    {
        private List<Profile> profiles = new List<Profile>();
        private int lastInsertedId = 0;

        public void ChangePassword(string passwordNew, int id)
        {
            var profile = profiles.FirstOrDefault(p => p.ID == id);
            if (profile != null)
            {
                profile.Password = passwordNew;
            }
        }

        public void CreateProfile(Profile profile)
        {
            profile.ID = ++lastInsertedId;
            profiles.Add(profile);
        }

        public void DeleteProfile(int id)
        {
            profiles.RemoveAll(p => p.ID == id);
        }

        public List<Profile> GetAllProfiles()
        {
            return new List<Profile>(profiles);
        }

        public int GetLastInsertedId()
        {
            return lastInsertedId;
        }

        public Profile Login(string email)
        {
            return profiles.FirstOrDefault(p => p.Email == email);
        }

        public bool ProfileExistsByEmail(string email)
        {
            return profiles.Any(p => p.Email == email);
        }

        public void UpdateProfile(Profile updatedProfile)
        {
            var profile = profiles.FirstOrDefault(p => p.ID == updatedProfile.ID);
            if (profile != null)
            {
                profiles.Remove(profile);
                profiles.Add(updatedProfile);
            }
        }
    }


}
