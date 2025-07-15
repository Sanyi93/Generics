using System;
using System.Xml.Schema;



namespace MyArrayApp
{
class Car
{

    public static void Main(string[] args)
    {
            //Car BlueCar = new Car();
            //Console.WriteLine("The blue car is " + BlueCar.marke);
            //Console.WriteLine(blueCar.color + blueCar.marke);

            Car GreenCar = new Car("EZW", "Green", 2010);
            GreenCar.marke = "Toyota";
            GreenCar.color = "green";
            GreenCar.year = 1999;
            Console.WriteLine("The green car characteristics: " + GreenCar.model + " " + GreenCar.color + " " + GreenCar.year);

    }
        //constructor
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        string model;
        string modelname;
        string color;
        string marke;
        int year;
    }
}
