using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        Server fileServer = new Server("192.168.1.1", 1000, "Windows Server", "File Server");
        Workstation userComputer = new Workstation("192.168.1.2", 500, "Windows 10");
        Router homeRouter = new Router("192.168.1.3", 800, "RouterOS");

        Network network = new Network();

        network.Connect(fileServer);
        network.TransmitData(fileServer, userComputer, "Retrieve important files");

        network.Connect(homeRouter);
        network.TransmitData(homeRouter, fileServer, "Forwarding external requests");

        network.Disconnect(userComputer);
    }
}