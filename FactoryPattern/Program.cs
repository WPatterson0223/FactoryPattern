namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on your vehicle?");
            int input = int.Parse(Console.ReadLine());

            IVehicle userVehicle = VehicleFactory.GetVehicle(input);
            userVehicle.Drive();
        }
    }
}
