
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
	public interface IProfileDAO
	{
		void CreateProfile(Profile Profile);
        void DeleteProfile(int id);
        void UpdateProfile(Profile Profile);
		List<Profile> GetAllProfiles();
		Profile Login(string email, string password);
        bool ProfileExistsByEmail(string email);
        void ChangePassword(string passwordNew, int id);
		int GetLastInsertedId();

    }
}
