using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class ParameterizedConstructorExample
    {
        public string _name;
        public int _age;
        public ParameterizedConstructorExample( string name, int age)
        {
            Console.WriteLine("Parameterized Constructor called.");
            _name = name;
            _age = age;
            Console.WriteLine("User Name is " + _name + " and age is " + _age);

        }
    }
}
