using LL;
using LL.GP_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Fakers;

namespace UnitTests.Tests
{
    [TestClass]
    public class GPTests
    {
        GPManager gpManager = new GPManager(new FakeGPDAO());

        [TestMethod]
        public void CreateGPTest()
        {
            var circuit = new Circuit(1, "Test Circuit", 50, 5.8, 20, 9.5);
            var gp = new GP(0, circuit, DateOnly.FromDateTime(DateTime.Now));

            gpManager.CreateGP(gp);
            var addedGP = gpManager.GetGPByID(gp.ID);

            Assert.IsNotNull(addedGP);
            Assert.AreEqual(gp.Circuit.Name, addedGP.Circuit.Name);
        }

        [TestMethod]
        public void DeleteGPTest()
        {
            var circuit = new Circuit(2, "Another Circuit", 60, 6.2, 22, 8.9);
            var gp = new GP(0, circuit, DateOnly.FromDateTime(DateTime.Now));
            gpManager.CreateGP(gp);

            gpManager.DeleteGP(gp.ID);
            var deletedGP = gpManager.GetGPByID(gp.ID);

            var result = gpManager.GetGPByID(gp.ID);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateGPTest()
        {
            var circuit = new Circuit(3, "Old Circuit", 70, 7.1, 25, 7.5);
            var gp = new GP(0, circuit, DateOnly.FromDateTime(DateTime.Now));
            gpManager.CreateGP(gp);

            var newCircuit = new Circuit(3, "Updated Circuit", 75, 7.3, 28, 8.0);
            gp.Circuit = newCircuit;

            gpManager.UpdateGP(gp);
            var updatedGP = gpManager.GetGPByID(gp.ID);

            Assert.IsNotNull(updatedGP);
            Assert.AreEqual("Updated Circuit", updatedGP.Circuit.Name);
        }
    }
}
