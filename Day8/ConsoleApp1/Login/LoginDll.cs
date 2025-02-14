using System;

namespace Login
{
    public class LoginDll
    {
        public string DoLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                return "Username cannot be empty";

            if (string.IsNullOrEmpty(password))
                return "Password cannot be empty";

            if (username == "admin" && password == "admin")
                return "Login successful";
            else
                return "Invalid credentials";
        }
    }
}
