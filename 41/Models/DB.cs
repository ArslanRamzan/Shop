using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _41.Models
{
    public class DB
    {
        public static Boolean Validate(String name,String pass)
        {
            if (name == "admin" && pass == "admin")
                return true;
            else
                return false;
        }
    }
}