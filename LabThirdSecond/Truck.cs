public class Truck : Vehicle
{
    public Truck(int speed, int size, VehicleType type) : base(speed, size, type)
    {
    }

    public override void Move(Road road)
    {
        position += GetSpeed() / 2;
    }

    public override void Stop()
    {
        Console.WriteLine("Truck stopped");
    }
}