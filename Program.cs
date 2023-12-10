using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace dz15hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1: List methods of the Console class
            Type consoleType = typeof(Console);
            MethodInfo[] methods = consoleType.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }

            // TASK 2: Explore properties of MyClass
            MyClass myInstance = new MyClass();
            myInstance.Prop1 = 20;
            myInstance.Prop2 = "Dobryi den";

            Type myType = myInstance.GetType();

            foreach (var property in myType.GetProperties())
            {
                object value = property.GetValue(myInstance);
                Console.WriteLine($"{property.Name}: {value}");
            }

            // TASK 3: Invoke Substring method on a string
            string myString = "Hello world!";
            Type stringType = typeof(string);

            MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
            object[] parameters = { 5, 5 };
            object result = substringMethod.Invoke(myString, parameters);

            Console.WriteLine(result);

            // TASK 4: Explore constructors of List<>
            Type listType = typeof(List<>);
            ConstructorInfo[] constructors = listType.GetConstructors();

            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
        }

        class MyClass
        {
            public int Prop1 { get; set; }
            public string Prop2 { get; set; }
        }
    }
}
