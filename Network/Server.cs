public class Server : Computer
{
    public string ServerType { get; set; }

    public Server(string ipAddress, int power, string osType, string serverType)
        : base(ipAddress, power, osType)
    {
        ServerType = serverType;
    }
}