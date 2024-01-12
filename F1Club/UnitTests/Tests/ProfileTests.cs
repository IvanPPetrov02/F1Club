using LL;
using LL.Profile_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Fakers;
using static LL.Profile_related.ProfileManager;

namespace UnitTests.Tests
{
    [TestClass]
    public class ProfileTests
    {
        ProfileManager profileManager = new ProfileManager(new ProfileDAOFake());

        [TestMethod]
        public void CreateProfileTest()
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now.Date);
            Profile profile = new Profile(22, "johndoe@email.com", "johndoe", "john", "doe", date, "088223344550", UserType.Analyser);
            profileManager.CreateProfile(profile);
            Assert.AreEqual(profileManager.GetProfileByID(1), profile);
        }

        [TestMethod]
        public void CreateProfile_InvalidDateOfBirth_ThrowsInvalidDateOfBirthException()
        {
            DateOnly date = new DateOnly(1800, 1, 1);
            var invalidProfile = new Profile(22, "johndoe@email.com", "johndoe", "john", "doe", date, "088223344550", UserType.Analyser);

            Assert.ThrowsException<InvalidDateOfBirth>(() => profileManager.CreateProfile(invalidProfile));
        }

        [TestMethod]
        public void UpdateProfile_ValidData_UpdatesProfile()
        {
            var originalProfile = new Profile(1, "original@email.com", "password", "Original", "User", DateOnly.FromDateTime(DateTime.Now), "1234567890", UserType.Analyser);
            profileManager.CreateProfile(originalProfile);

            var updatedProfile = new Profile(1, "updated@email.com", "newpassword", "Updated", "User", DateOnly.FromDateTime(DateTime.Now), "0987654321", UserType.Admin);

            profileManager.UpdateProfile(updatedProfile, originalProfile.Email);

            var result = profileManager.GetProfileByID(1);
            Assert.AreEqual(updatedProfile.Email, result.Email);
            Assert.AreEqual(updatedProfile.FirstName, result.FirstName);
        }

        [TestMethod]
        public void DeleteProfile_ValidId_DeletesProfile()
        {
            var profile = new Profile(1, "delete@email.com", "password", "Delete", "User", DateOnly.FromDateTime(DateTime.Now), "1234567890", UserType.Analyser);
            profileManager.CreateProfile(profile);

            profileManager.DeleteProfile(1);

            var result = profileManager.GetProfileByID(1);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllProfiles_ReturnsAllProfiles()
        {
            var profile1 = new Profile(1, "user1@email.com", "password", "User", "One", DateOnly.FromDateTime(DateTime.Now), "1234567890", UserType.Analyser);
            var profile2 = new Profile(2, "user2@email.com", "password", "User", "Two", DateOnly.FromDateTime(DateTime.Now), "0987654321", UserType.Admin);
            profileManager.CreateProfile(profile1);
            profileManager.CreateProfile(profile2);

            var result = profileManager.GetAllProfiles();

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Login_ValidCredentials_ReturnsProfile()
        {
            var profile = new Profile(1, "login@email.com", "password", "Login", "User", DateOnly.FromDateTime(DateTime.Now), "1234567890", UserType.Analyser);
            profileManager.CreateProfile(profile);

            var result = profileManager.Login(profile.Email, "password");

            Assert.IsNotNull(result);
            Assert.AreEqual(profile.Email, result.Email);
        }
    }
}
