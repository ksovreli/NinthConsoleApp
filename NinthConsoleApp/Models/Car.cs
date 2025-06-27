namespace NinthConsoleApp.Models
{
    internal class Car : Vehicle
    {
        public int InitialFuel { get; set; }

        public Car(int InitialFuel)
        {
            this.Fuel = InitialFuel;
        }
    }
}
