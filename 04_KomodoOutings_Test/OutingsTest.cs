using _04_KomodoOutings_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_KomodoOutings_Test
{
    [TestClass]
    public class OutingsTest
    {
        [TestMethod]
        public void SetOutingName_ShouldSetCorrectName()
        {
            Outings outing = new Outings();
            outing.OutingName = "JulyGolf";

            string exp = "JulyGolf";
            string act = outing.OutingName;

            Assert.AreEqual(exp, act);
        }
    }
}
