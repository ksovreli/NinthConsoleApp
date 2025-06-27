namespace NinthConsoleApp.Models
{
    internal class Vehicle
    {
        public int Fuel { get; set; }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Vehicle is driving");
            }

            else
            {
                Console.WriteLine("Vehicle stopped, no fuel!");
            }
        }


        public int Refuel(int Fuelamount)
        {
            if (Fuelamount > 0)
            {
                Fuel += Fuelamount;
                Console.WriteLine($"Refueled with {Fuelamount} liters. current fuel is {Fuel}");
            }

            else
            {
                Console.WriteLine("Invalid! amount should be positive!");
            }
            return Fuel;    
        }
    }
}
