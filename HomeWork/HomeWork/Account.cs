using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Account
    {
        public string LogIn(string username, string password)
        {
            if (CheckUserAndPass(username, password))
            {
                return "Entry is Successful";
            }
            else
            {
                return "Username or Passwor is wrong";
            }
        }
        public bool CheckUserAndPass(string user, string pass)
        {
            if (user == "cavid123" && pass == "Cavid1993")
            {
                return true;
            }
            return false;
        }
    }
}
