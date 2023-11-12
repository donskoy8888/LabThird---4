public interface IConnectable
{
    void Connect(Computer target);
    void Disconnect(Computer target);
    void TransmitData(Computer source, Computer target, string data);
}