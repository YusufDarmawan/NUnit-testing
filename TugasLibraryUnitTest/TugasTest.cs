using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;
namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class TugasTest
    {
        private Day day;
        private User user;
        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();
        }
        [Test]
        public void Daytest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
        }
        [Test]
        public void Usertest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }

    }
}
