using System;
using System.Drawing;
using System.Reflection;

namespace MyArrayApp
{
    class Person
    {
        
        public static void Main(string[] args)
        {

            Person John = new Person("John", "Wick", 50);

            Console.WriteLine("This person is " + John.firstName);

        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        private string firstName; //private = accessible only whithin class, therefore property needed
        public required string FirstName //property
        { get { return firstName; }
          set { firstName = value; }
        }

        private string lastName;
        public required string LastName //property
        { get { return lastName; }
         set { lastName = value; }
        }

        private int age;
        public required int Age //property
        { get { return age; }
          set { age = value; }
        }
           


    }

    class Program
    {
        static void Main(string[] args)
        {
            Person Max = new Person("Max", "Maxenssen", 30);

            Console.WriteLine("Hey, this is " + Max.FirstName);
            
            
        }
    }

    
}
