using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }

    public interface ICarBuilder
    {
        void SetMake(string make);
        void SetModel(string model);
        void SetYear(int year);
        void SetColor(string color);
        Car GetCar();
    }

    public class CarBuilder : ICarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public void SetMake(string make)
        {
            _car.Make = make;
        }

        public void SetModel(string model)
        {
            _car.Model = model;
        }

        public void SetYear(int year)
        {
            _car.Year = year;
        }

        public void SetColor(string color)
        {
            _car.Color = color;
        }

        public Car GetCar()
        {
            return _car;
        }
    }

    public class CarDirector
    {
        private readonly ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCar()
        {
            _builder.SetMake("Toyota");
            _builder.SetModel("Corolla");
            _builder.SetYear(2022);
            _builder.SetColor("Red");
        }
    }


}
