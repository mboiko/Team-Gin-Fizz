using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame
{
   static class Validation
    {
      public static string IsCorrectLogin(string username, string password)
       {
           string message=string.Empty;
           if (username.Length < 3 )
           {
               message +=  "Username must be at least 3 chars long\n" ;
           }
           if(password.Length < 3)
           {
               message += "Password must be at least 3 chars long";
           }
           return message;
       }
    }
}
