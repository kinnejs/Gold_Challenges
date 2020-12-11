using _02_KomodoClaims_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_KomodoClaims_Test
{
    [TestClass]
    public class ClaimsTest
    {
        [TestMethod]
        public void SetClaimID_ShouldSetCorrectInt()
        {
            //Assert
            Claims claim = new Claims();
            claim.ClaimID = 151;

            //Act
            int exp = 151;
            int act = claim.ClaimID;

            //Assert
            Assert.AreEqual(exp, act);
        }
    }
}
