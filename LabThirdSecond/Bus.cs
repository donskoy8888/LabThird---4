public class Bus : Vehicle
{
    public Bus(int speed, int size, VehicleType type) : base(speed, size, type)
    {
    }

    public override void Move(Road road)
    {
        position += GetSpeed() / 3;
    }

    public override void Stop()
    {
        Console.WriteLine("Bus stopped");
    }
}