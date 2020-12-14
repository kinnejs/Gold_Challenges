using _04_KomodoOutings_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_KomodoOutings_Test
{
    [TestClass]
    public class OutingsRepoTest
    {
        private OutingsRepo _repo;
        private Outings _outings;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new OutingsRepo();
            _outings = new Outings("JulyGolf", OutingType.Golf, 30, DateTime.Parse("7/13/2020"), 100.00);

            _repo.AddOuting(_outings);
        }

        [TestMethod]
        public void AddToList_ShouldBeNotNull() 
        {
            //Arange
            Outings outing = new Outings();
            outing.OutingName = "JulyGolf";
            OutingsRepo repo = new OutingsRepo();

            //Act
            repo.AddOuting(outing);
            Outings itemFromDir = repo.GetOutingByName("JulyGolf");

            //Assert
            Assert.IsNotNull(itemFromDir);
        }

        [TestMethod]
        public void DeleteOuting_ShouldReturnFalse()
        {
            bool deleteResult = _repo.RemoveOuting(_outings.OutingName);

            Assert.IsTrue(deleteResult);
        }

        [TestMethod]
        public void UpdateExistingOuting_ShouldReturnTrue()
        {
            //Arrange
            Outings newOuting = new Outings("JulyGolf", OutingType.Golf, 30, DateTime.Parse("7/13/2020"), 100.00);

            //Act
            bool updateResult = _repo.UpdateOuting("JulyGolf", newOuting);

            //Assert
            Assert.IsTrue(updateResult);
        }
    }
}
