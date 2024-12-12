using System;

namespace CarLibrary
{
    public class Car
    {
        protected internal string model = "Mustang";

        public void Test()
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }

    public class DerivedCar : Car
    {
        public void ShowModel()
        {
            Console.WriteLine("DerivedCar Model: " + model);
        }
    }
}
