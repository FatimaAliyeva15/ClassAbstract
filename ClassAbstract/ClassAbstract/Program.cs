namespace ClassAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Car car1 = new Car("BMW", "X5", 2019, 220);
            Car car2 = new Car("Toyota", "Camry", 2020, 200);


            Bus bus1 = new Bus(30, 2018);
            Bus bus2 = new Bus(40, 2017);

            Vehicle[] veicles =  {car1, car2, bus1, bus2};



            foreach (var item in veicles)
            {
                item.ShowInfo();
            }
        }
    }
}
