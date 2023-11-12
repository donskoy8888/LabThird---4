public class TrafficSimulation
{
    private List<Vehicle> vehicles;
    private List<Road> roads;

    public TrafficSimulation(List<Vehicle> vehicles, List<Road> roads)
    {
        this.vehicles = vehicles;
        this.roads = roads;
    }

    public void Simulate()
    {
        for (int i = 0; i < vehicles.Count; i++)
        {
            Vehicle vehicle = vehicles[i];
            Road road = roads[i % roads.Count];
            vehicle.Move(road);
        }
    }
}