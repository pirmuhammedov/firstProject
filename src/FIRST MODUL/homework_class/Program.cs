﻿namespace homework_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planetsName = new List<Planet>();
            Planet planet = new Planet();
            planet.Name = "Earth";
            planet.Color = "Blue";
            planet.LocatedNumber = 3;

            var animals = new List<Animal>();

            Animal firstAnimal = new Animal()
            {
                Name = "wite bear",
                Weight = 800,
                Color = "wite",
                Type = "Wild animals",
                Live = "Antarctica and Arctica"
            };

            var books = new List<Book>();

            Book firstBook = new Book()
            {
                Name = "O'tgan kunlar",
                PageCount = 401,
                About = "Roman",
                Price = 30000,
                ProductionYear = 1926,
                Writer = "Abdulla Qodiriy"
            };

            var House = new List<Book>();

            House firstHouse = new House()
            {
                Price = 220000,
                Location = "Tashkent, Mirobod",
                NumberOfRums = 12,
                Size = 10,
                YearOfBuild = 2018
            };

            var movies = new List<Movie>();

            Movie firstMovie = new Movie()
            {
                Name = "Venom 3",
                Gerne = "Fantastic",
                RunningTime = 2.25,
                YearOfProduction = 2024
            };

            var phones = new List<Phone>();

            Phone firstPhone = new Phone()
            {
                Name = "iPhone 12 Pro",
                Color = "Gold",
                Price = 360,
                MemorySize = 128,
                BatteryPower = 2815
            };

            var bmwCars = new List<BMW>();

            BMW bMW = new BMW()
            {
                Model = "M5 E60",
                Color = "black",
                MotoreSize = 4.0,
                Weight = 1780,
                Year = 2010,
                Price = 22.500
            };

        }
    }
}
