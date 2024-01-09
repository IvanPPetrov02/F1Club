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
        ProfileManager profileManager = new ProfileManager(new PrfoileDAOFake());

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
    }
}
