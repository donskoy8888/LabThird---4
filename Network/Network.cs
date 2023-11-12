public class Network : IConnectable
{
    public void Connect(Computer target)
    {
        Console.WriteLine($"Connected to {target.IpAddress}");
    }

    public void Disconnect(Computer target)
    {
        Console.WriteLine($"Disconnected from {target.IpAddress}");
    }

    public void TransmitData(Computer source, Computer target, string data)
    {
        Console.WriteLine($"Transmitting data from {source.IpAddress} to {target.IpAddress}: {data}");
    }
}