using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstract
{
    internal class Bus : Vehicle
    {
        public Bus(int passengercount, int year):base(year)
        {
            PassengerCount = passengercount;
        }

        private int _passengerCount;

        public int PassengerCount
        {
            get { return _passengerCount; }

            set
            {
                bool check = false;
                do
                {
                    if (value > 0)
                    {
                        _passengerCount = value;
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Speed duzgun daxil et");
                        string count;
                        do
                        {
                            Console.Write("Speed: ");
                            count = Console.ReadLine();
                        } while (!int.TryParse(count, out value));
                    }
                } while (!check);
            }
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"PassengerCount: {PassengerCount}, Year: {Year}"); 
        }
    }
}
