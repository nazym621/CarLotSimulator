using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            var newCar = new Car();
            newCar.EngineNoise = "Vroom";
            newCar.Make = "Ford";
            newCar.Model = "Escape";
            newCar.HonkNoise = "Loud";
            newCar.IsDriveable = true;
            newCar.Year = 2006;

            
            

            Console.WriteLine($"{newCar.Year}, {newCar.Make}, {newCar.Model}, {newCar.HonkNoise}, {newCar.EngineNoise}, {newCar.IsDriveable}");

            var sanazsCar = new Car()
            {
                Year = 2014,
                Make = "Ford",
                Model = "Escape",
                EngineNoise = "Room Room",
                HonkNoise = "Beep",
                IsDriveable = true,
            };
            
                

            var saharsCar = new Car();
            var momsCar = new Car();
            //Call each of the methods for each car

            carLot.CarCollection.Add(newCar);
            carLot.CarCollection.Add(momsCar);

            foreach(var car in carLot.CarCollection)
            {
                Console.WriteLine($"{car.Model}");
            }
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
