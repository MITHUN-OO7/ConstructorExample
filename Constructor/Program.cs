using System;

namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            DefaultConstructor defaultConstructor = new DefaultConstructor();
            Console.WriteLine(defaultConstructor.name);
            Console.WriteLine(defaultConstructor.age);
            Console.WriteLine("--->End of Default Constructor" + Environment.NewLine);

            //******************************************Parameterized Constructor
            ParameterizedConstructorExample parameterizedConstructorExample = new ParameterizedConstructorExample("Mithun Kumar", 28);
            //Console.WriteLine(parameterizedConstructorExample._name);
            //Console.WriteLine(parameterizedConstructorExample._age);
            Console.WriteLine("--->End of Parameterized Constructor" + Environment.NewLine);

            //******************************************Copy Constructor

            Console.WriteLine("Copy Constructor");
            CopyConstructor copyConstructor = new CopyConstructor("Mithun Kumar", 1990);
            // here is g1 details is copied to g2.
            CopyConstructor copyConstructor1 = new CopyConstructor(copyConstructor);
            Console.WriteLine(copyConstructor1.GetDatail());
            Console.WriteLine("--->End of Copy Constructor" + Environment.NewLine);
            //******************************************Private Constructor
            Console.WriteLine("Private Constructor");

            //It is the implementation of a singleton class pattern.
            //use private constructor when we have only static members.
            //Using private constructor, prevents the creation of the instances of that class.
            //PrivateConstructor privateConstructor = new PrivateConstructor();

            PrivateConstructor.name = "Rajeev Kumar";
            PrivateConstructor.year = 1991;
            PrivateConstructor.GetDetail();
            Console.WriteLine(PrivateConstructor.GetDetail());
            Console.WriteLine("--->End of Private Constructor" + Environment.NewLine);
            //******************************************Static Constructor

            StaticConstructor obj = new StaticConstructor(1);
            Console.WriteLine(obj.GetDetail("Mithun", 1990));
            StaticConstructor obj1 = new StaticConstructor(2);
            Console.WriteLine(obj1.GetDetail("Rajeev", 1990));
        }
    }
}
