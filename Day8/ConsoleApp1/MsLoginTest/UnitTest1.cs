using Microsoft.VisualStudio.TestTools.UnitTesting;
using Login;

namespace Login
{
    [TestClass]
    public class Login
    {
        private LoginDll login;

        [TestInitialize]
        public void Setup()
        {
        LoginDll    login = new LoginDll();
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
