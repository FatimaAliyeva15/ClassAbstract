using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstract
{
    internal abstract class Vehicle
    {

        public Vehicle(int year)
        {
            Year = year;
        }

        public string Color { get; set; }

        public int Year { get; set; }

        public abstract void ShowInfo();
        
    }
}
