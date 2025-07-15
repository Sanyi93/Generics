using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulationApp.cs
{
    internal class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String City { get; set; }

        //overriding the toString method to easily print the Person objects

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, City: {City}";
        }


        // A separate class to manage the collection of persons and perform queries
        public static class PersonRepository
        {

            //a static readonly list
            private static readonly List<Person> allPersons = new List<Person>
            {
                new Person {Id = 1, Name ="Martin", City = "Wien"},
                new Person {Id = 2, Name = "Marian", City = "Innsbruck"},
                new Person {Id = 3, Name = "Florian", City = "Wiener Neustadt"},
                new Person {Id = 4, Name = "Tim", City = "Dornbirn"},
                new Person {Id = 5, Name = "Oliver", City = "Klagenfurt"},
                new Person {Id = 6, Name = "Karl", City = "Graz"},
                new Person {Id = 7, Name = "Oliver", City = "Wien"},
                new Person {Id = 8, Name = "Marian", City = "Graz"},
                new Person {Id = 9, Name = "Ema", City = "Innsbruck"},
                new Person {Id = 10, Name = "Petra", City = "Klagenfurt"}
            };


            // Methods now return IEnumerable<Person> for flexibility, not arrays or void
            public static IEnumerable<Person> SelectById(int id)
        {

            return allPersons.Where(p => p.Id == id);

            //Person[] personById = allPersons.Where(p => p.Id == Id).ToArray();
            //foreach (Person person in personById) 
            //{
            //    Console.WriteLine(person.Name);
               
            //}
        }

        public static IEnumerable<Person> SelectByName(string name)
        {

                return allPersons.Where(p => p.Name == name);

                //Person[] personByName = allPersons.Where(p => p.Name == Name).ToArray();
                //foreach(Person person in personByName)
                //{
                //    Console.WriteLine(person.Name);
                //}
            }

            public static IEnumerable<Person> SelectByCity(string city)
        {

                return allPersons.Where(p => p.City == city);

            //Person[] personByCity = allPersons.Where(p => p.City == City).ToArray();
            //foreach(Person person in personByCity)
            //{
            //    Console.WriteLine(person.Name);
            //}
        }
       
        }
    }
    
}
