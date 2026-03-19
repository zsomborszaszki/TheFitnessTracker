using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheFitnessTracker;


namespace MyApp.Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void CreateRecord_ShouldNotBeNull()
        {
            var record = new InsertDatas("Futás", 30);

            Assert.IsNotNull(record);
        }

        [TestMethod]
        public void GetRecord_ShouldReturnCorrectName()
        {
            var record = new Workout("Futás", 30);

            var name = record.Name;

            Assert.AreEqual("Futás", name);
        }

        [TestMethod]
        public void ExportToCsv_ShouldContainData()
        {
            var record = new Workout("Futás", 30);

            var csv = record.ToCsv();

            Assert.IsTrue(csv.Contains("Futás"));
        }

        [TestMethod]
        public void ImportFromCsv_ShouldCreateCorrectObject()
        {
            string csv = "Futás,30";

            var record = Workout.FromCsv(csv);

            Assert.AreEqual("Futás", record.Name);
        }

        [TestMethod]
        public void Validate_ShouldReturnFalse_ForInvalidData()
        {
            var record = new Workout("", -5);

            bool isValid = record.IsValid();

            Assert.IsFalse(isValid);
        }
    }
}
