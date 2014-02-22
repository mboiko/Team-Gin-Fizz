using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame.Classes
{
   static class Validation
    {
       static bool IsCorrectLogin(string username, string password)
       {
           if (username.Length < 3 && password.Length < 3)
           {
               return false;
           }
           return true;
       }
    }
}
