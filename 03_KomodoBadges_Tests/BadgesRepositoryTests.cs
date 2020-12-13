using _03_KomodoBadges_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_KomodoBadges_Tests
{
    [TestClass]
    public class BadgesRepositoryTests
    {
        private BadgesRepository _repo;
        private Badges _badge; 

        [TestInitialize]
        public void Arrange()
        {
            _repo = new BadgesRepository();

        }
    }
}
