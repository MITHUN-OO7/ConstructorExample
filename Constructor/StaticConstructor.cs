using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor");

        }
        public StaticConstructor(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string GetDetail(string name, int year)
        {
            return "User Name is " + name + " and date of year is " + year;
        }
    }
}
