using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WinFormProject.Model
{
    public static class Helpers
    {
         public static string HashCode(string str)
        {
            byte[] passhashcode = Encoding.ASCII.GetBytes(str);
            byte[] pass = new SHA256Managed().ComputeHash(passhashcode);
            return Encoding.ASCII.GetString(pass);
        }
    }
}
