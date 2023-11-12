public class Car : Vehicle
{
    public Car(int speed, int size, VehicleType type) : base(speed, size, type)
    {
    }

    public override void Move(Road road)
    {
        position += GetSpeed();
    }

    public override void Stop()
    {
        Console.WriteLine("Car stopped");
    }
}