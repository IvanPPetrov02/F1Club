using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LL.Profile_related
{
	public class ProfileManager
	{
		IProfileDAO profileDAO;
		public ProfileManager(IProfileDAO profileDAO)
		{
			this.profileDAO = profileDAO;
		}

        private static List<Profile>? Profiles = new List<Profile>();

        private void PopulateIfEmpty()
        {
            if (Profiles.Any())
            {
                return;
            }
            else
            {
                RefreshProfilesFromDatabase();
            }
        }

        private int GetLastInsertedId()
        {
            try
            {
                return profileDAO.GetLastInsertedId();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void ChangePassword(string passwordNew, string passwordCurrent, int id)
		{
            Profile profile = GetProfileByID(id);
            if (passwordCurrent == profile.Password)
            {
                profileDAO.ChangePassword(HashPassword(passwordNew), id);
                profile.Password = HashPassword(passwordNew);
            }
            else
            {
                throw new Exception("Password cannot be the same as old password!");
            }
        }

        public string CreateEmail(string fName, string lName)
        {
            while (lName.Length < 3)
            {
                lName += lName;
            }

            string email = fName.Substring(0, 1).ToUpper() + lName.Substring(0, 3).ToUpper() + "@F1Club.com";
            int i = 1;

            while (profileDAO.ProfileExistsByEmail(email))
            {
                email = fName.Substring(0, 1).ToUpper() + lName.Substring(0, 3).ToUpper() + i + "@F1Club.com";
                i++;
            }

            return email;
        }

		public class DuplicateEmailException : Exception
		{
			public DuplicateEmailException(string message) : base(message) { }
		}

		public class InvalidDateOfBirth : Exception
		{
			public InvalidDateOfBirth(string message) : base(message) { }
		}

        private string HashPassword(string password)
        {
            string randomSalt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, randomSalt);
            return hashedPassword;
        }

		public void CreateProfile(Profile Profile)
        {
            DateOnly minValidDate = new DateOnly(1900, 1, 1);
            DateOnly maxValidDate = DateOnly.FromDateTime(DateTime.Now);
            if (Profile.DateOfBirth < minValidDate || Profile.DateOfBirth > maxValidDate)
            {
                DateOnly minValidBirthdate = maxValidDate.AddYears(-18);
                throw new InvalidDateOfBirth($"Date of birth must be betwwen 01/01/1900 and {minValidBirthdate}.");
            }

            if (profileDAO.ProfileExistsByEmail(Profile.Email))
            {
                throw new DuplicateEmailException($"Email {Profile.Email} already exists.");
            }

            Profile.Password = HashPassword(Profile.Password);

            profileDAO.CreateProfile(Profile);

            Profile.ID = GetLastInsertedId();
            Profiles.Add(Profile);
        }

        public void DeleteProfile(int id)
		{
            profileDAO.DeleteProfile(id);

            PopulateIfEmpty();
            Profile profileToRemove = Profiles?.FirstOrDefault(profile => profile.ID == id);
            if (profileToRemove != null)
            {
                Profiles.Remove(profileToRemove);
            }
        }

        private void RefreshProfilesFromDatabase()
        {
            Profiles?.Clear();

            foreach (Profile profile in profileDAO.GetAllProfiles())
            {
                Profiles.Add(profile);
            }
        }

        public List<Profile> GetAllProfiles()
		{
            RefreshProfilesFromDatabase();
            return Profiles;
        }

        public List<Profile> GetAllUsersByUserType(UserType userType)
        {
            try
            {
                PopulateIfEmpty();
                List<Profile> profiles = Profiles.Where(p => p.UserType == userType).ToList();
                return profiles;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public Profile GetProfileByID(int id)
		{
            PopulateIfEmpty();
            Profile profile = Profiles?.FirstOrDefault(profile => profile.ID == id);
            return profile;
        }

		public Profile Login(string email, string password)
		{
            Profile profile = profileDAO.Login(email, password);
            if (PasswordCheck(password, profile.Password))
            {
                return profile;
            }
            else
            {
                return null;
            }

        }
        private bool PasswordCheck(string password, string DBPassword)
        {
            if (BCrypt.Net.BCrypt.Verify(password, DBPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public void UpdateProfile(Profile Profile, string LastEmail)
		{
            DateOnly minValidDate = new DateOnly(1900, 1, 1);
            DateOnly maxValidDate = DateOnly.FromDateTime(DateTime.Now);
            if (Profile.DateOfBirth < minValidDate || Profile.DateOfBirth > maxValidDate)
            {
                DateOnly minValidBirthdate = maxValidDate.AddYears(-18);
                throw new InvalidDateOfBirth($"Date of birth must be betwwen 01/01/1900 and {minValidBirthdate}.");
            }

            if (Profile.Email != LastEmail)
            {
                if (profileDAO.ProfileExistsByEmail(Profile.Email))
                {
                    throw new DuplicateEmailException($"Profile with email - {Profile.Email} already exists.");
                }
            }
            
            profileDAO.UpdateProfile(Profile);

            PopulateIfEmpty();
            Profile existingProfile = Profiles?.First(profile => profile.ID == Profile.ID);
            if (existingProfile != null)
            {
                existingProfile.Email = Profile.Email;
                existingProfile.FirstName = Profile.FirstName;
                existingProfile.LastName = Profile.LastName;
                existingProfile.DateOfBirth = Profile.DateOfBirth;
                existingProfile.PhoneNumber = Profile.PhoneNumber;
                existingProfile.UserType = Profile.UserType;
            }
        }

        public List<Profile> GetAllProfilesRefresh()
        {
            PopulateIfEmpty();
            return Profiles.ToList();
        }

        public bool PasswordMatch(string email, string password)
        {
            Profile profile = GetProfileByEmail(email);
            if (PasswordCheck(password, profile.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Profile GetProfileByEmail(string email)
        {
            Profile profile = Profiles?.FirstOrDefault(profile => profile.Email == email);
            return profile;
        }
    }
}
