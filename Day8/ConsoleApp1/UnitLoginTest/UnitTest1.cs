using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginLibrary;
using NUnit.Framework;

namespace LoginTests
{
    [TestClass]
    public class LoginUnitTests
    {
        private Login login;

        [TestInitialize]
        public void Setup()
        {
            login = new Login();
        }

        [TestMethod]
        public void Check_Username_Null()
        {
            string result = login.DoLogin("", "admin");
            Assert.AreEqual("Username cannot be empty", result);
        }

        [TestMethod]
        public void Check_Password_Null()
        {
            string result = login.DoLogin("admin", "");
            Assert.AreEqual("Password cannot be empty", result);
        }

        [TestMethod]
        public void Check_Invalid_Credentials()
        {
            string result = login.DoLogin("user", "1234");
            Assert.AreEqual("Invalid credentials", result);
        }
    }
}
