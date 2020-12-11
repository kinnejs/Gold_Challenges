using _02_KomodoClaims_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_KomodoClaims_Test
{
    [TestClass]
    public class ClaimsRepoTest
    {
        private ClaimsRepository _repo;
        private Claims _claim;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimsRepository();
            _claim = new Claims(1, ClaimType.Home, "Home fire", 4000, Convert.ToDateTime(03 / 12 / 2020), Convert.ToDateTime(06 / 12 / 2020));

            _repo.AddClaimToList(_claim);
        }

        //Add Method
        [TestMethod]
        public void AddToList_ShouldBeNotNull()
        {
            //Arrange
            Claims claim = new Claims();
            claim.ClaimID = 1;
            ClaimsRepository repo = new ClaimsRepository();

            //Act
            repo.AddClaimToList(claim);
            Claims claimFromDir = repo.GetClaimsByClaimID(1);

            //Assert
            Assert.IsNotNull(claimFromDir);
        }

        //Update Method
        [TestMethod]
        public void UpdateExistingList_ShouldReturnTrue()
        {
            //Arrange
            //TestInitialize
            Claims newClaim = new Claims(1, ClaimType.Car, "Home fire", 5000, Convert.ToDateTime(03 / 12 / 2020), Convert.ToDateTime(06 / 12 / 2020));

            //Act
            bool updateResult = _repo.UpdateExistingList(1, newClaim);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow(1, true)]
        [DataRow(32, false)]
        public void UpdateExistingList_ShouldMatchGivenBool(string originalID, bool shouldUpdate)
        {
            //Arrange
            //TestInitialize
            Claims newClaim = new Claims(1, ClaimType.Car, "Home fire", 5000, Convert.ToDateTime(03 / 12 / 2020), Convert.ToDateTime(06 / 12 / 2020));

            //Act
            bool updateResult = _repo.UpdateExistingList(1, newClaim);

            //Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteClaim_ShouldReturnTrue()
        {
            //Act
            bool deleteResult = _repo.RemoveClaimFromList(_claim.ClaimID);

            //Assert
            Assert.IsTrue(deleteResult);
        }

    }   
}
