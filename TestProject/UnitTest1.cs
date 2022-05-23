using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using t.data.EF;
using t.domain.Entities;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetUser()
        {
            string userName = "Unit";
            string name = "Unit";
            User user1 = User.Create(0, userName, name);

            Mock<EFDbContext> mockDB = new Mock<EFDbContext>();
            mockDB.Setup(a => a.User.Add(user1)).Returns(user1);         

            var user = mockDB.Object.User.Add(user1);

            Assert.AreEqual(userName, user.UserName);


            //Assert.Equals(5, resultado);
        }
    }
}
