using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Auhtenticate(string userName, string password)
        {
            string msg;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "Use name and password required";
            }
            else
            if ((userName == "admin") && (password == "admin@1256"))
            {
                msg = "Authentication Pass";
            }
            else
            {
                msg = "Authentication Fail";
            }
            return msg;
        }
    }
}
