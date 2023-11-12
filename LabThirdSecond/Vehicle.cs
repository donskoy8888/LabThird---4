public enum VehicleType
{
    Car,
    Truck,
    Bus
}
public abstract class Vehicle
{
    private int speed;
    private int size;
    private VehicleType type;
    public int position;

    public Vehicle(int speed, int size, VehicleType type)
    {
        this.speed = speed;
        this.size = size;
        this.type = type;
        this.position = 0;
    }

    public int GetSpeed()
    {
        return speed;
    }

    public int GetSize()
    {
        return size;
    }

    public VehicleType GetType()
    {
        return type;
    }

    public abstract void Move(Road road);

    public abstract void Stop();

    public int GetPosition()
    {
        return position;
    }
}
