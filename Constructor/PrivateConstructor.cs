using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class PrivateConstructor
    {
        private PrivateConstructor()
        {
        }


        public static string name;
        public static int year;

        public static string GetDetail()
        {
            return "User Name is " + name + " and date of year is " + year;
        }

    }
}
