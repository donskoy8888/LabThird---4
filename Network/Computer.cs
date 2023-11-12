public class Computer
{
    public string IpAddress { get; set; }
    public int Power { get; set; }
    public string OsType { get; set; }

    public Computer(string ipAddress, int power, string osType)
    {
        IpAddress = ipAddress;
        Power = power;
        OsType = osType;
    }
}