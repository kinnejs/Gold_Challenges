using _03_KomodoBadges_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_KomodoBadges_Tests
{
    [TestClass]
    public class BadgesTest
    {
        [TestMethod]
        public void SetBadge_ShouldSetCorrect()
        {
            Badges badge = new Badges();

            badge.BadgeID = 123;

            int exp = 123;
            int act = badge.BadgeID;

            Assert.AreEqual(exp, act);
        }
    }
}
