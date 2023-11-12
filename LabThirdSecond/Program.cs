public class Program
{
    public static void Main()
    {
        Road road1 = new Road(1000, 10, 2);
        Road road2 = new Road(500, 20, 1);

        Vehicle car1 = new Car(70, 5, VehicleType.Car);
        Vehicle truck1 = new Truck(50, 10, VehicleType.Truck);
        Vehicle bus1 = new Bus(40, 6, VehicleType.Bus);

        List<Vehicle> vehicles = new List<Vehicle> { car1, truck1, bus1 };
        List<Road> roads = new List<Road> { road1, road2 };

        TrafficSimulation simulation = new TrafficSimulation(vehicles, roads);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Step {0}", i + 1);
            simulation.Simulate();

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetType() + ": " + vehicle.GetPosition());
            }
        }
    }
}