using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstract
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model, int year, double maxspeed):base(year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxspeed;
        }

        public string Brand { get; set; }
        public string Model { get; set; }    

        private double _maxspeed;

        public double MaxSpeed
        {
            get { return _maxspeed; }

            set
            {
                bool check = false;
                do
                {
                    if (value > 0)
                    {
                        _maxspeed = value;
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Speed duzgun daxil et");
                        string speed;
                        do
                        {
                            Console.Write("Speed: ");
                            speed = Console.ReadLine();
                        } while (!double.TryParse(speed, out value));
                    }
                } while (!check);
            }
        }

        public override void ShowInfo()
        {
            
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, MaxSpeed: {MaxSpeed}");
        }
    }
}
