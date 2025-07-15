// See https://aka.ms/new-console-template for more information

using System;
using System.IO.IsolatedStorage;

namespace MyArrayApp
{
    class ArrayBasics
    {
        static void Main(string[] args) {
            //Array basics;
            //starting with 0

            string[] cars;
            //when declaring array and initializing it later the keyword "new" cannot be ommitted
            cars = new string[] { "Ford", "Mercedes", "Skoda" };
            int[] numbers = { 10, 20, 30, 40 };
            numbers[2] = 77;
            //new array of 5 elements that is to be filled later
            string[] weekdays = new string[5];
            //new array of 3 elements filled by values
            string[] somePlanets = new string[3] { "Earth", "Mars", "Saturn" };
            //new array without specifying the size
            string[] rooms = new string[] { "bedroom", "kitchen" };

            //iterating over array
            for (int i = 0; i < somePlanets.Length; i++)
            {
                Console.WriteLine(somePlanets[i]);
            }

            //Sorting arrays; other dif functions such as Max, Min...
            Array.Sort(cars);
            foreach(string car in cars)
            {
                Console.WriteLine(car);

            }
            Console.WriteLine(numbers.Max());

            //MULTIDIMENSIONAL ARRAYS
            int[,] greatNumbers = { { 100, 102, 103 }, { 104, 105, 106 } };
            //105
            Console.WriteLine(greatNumbers[1,1]);

            //looping through the multiD arrays
            foreach(int gno in greatNumbers)
            {
                Console.WriteLine(gno);
            }

            //using "GetLength" instead of "Length" in case of MD Arrays
            for(int i = 0; i < greatNumbers.GetLength(0); i++)
            {
                for(int j = 0; j < greatNumbers.GetLength(1); j++)
                {
                    Console.WriteLine(greatNumbers[i, j]);
                }
            }

            NewMethod();
            MethodWithParam(50);
            MethodWithDefParam("Spain");
            MethodReturnsInt(20, 40);
            PlusMethod(11, 10);
            PlusMethod(3.55, 1.45);
          

        }

        /// <summary>
        /// //////static = method belonging to the Programm class and not to an object of the Program class!!!/////////////
        /// </summary>
        static void NewMethod()
        {
            Console.WriteLine("anything");
        }

        static void MethodWithParam(int age)
        {
            Console.WriteLine("Your age is " + age);
        }

        static void MethodWithDefParam(string country, string name = "Lewis")
        {
            Console.WriteLine(name + " is from " + country);

        }

        static int MethodReturnsInt(int firstNum, int secondNum)//similar with any other variables (e.g. string, boolean, double, float....)
        {
            int result =  firstNum +  secondNum;
            Console.WriteLine(result);
            return result; // ending the methods and returning controll to the caller
           
        }

        //Method Overloading -> multiple methods with the same name with different params

        static int PlusMethod(int firstNum, int secondNum)
        {
            int plusRes = firstNum + secondNum;
            Console.WriteLine(plusRes);
            return plusRes;

        }
        static double PlusMethod(double firstNum, double secondNum)
        {
            double plusRes = firstNum + secondNum;
            Console.WriteLine(plusRes);
            return plusRes;
        }





     }


}


