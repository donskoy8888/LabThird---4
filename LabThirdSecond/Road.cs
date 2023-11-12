public class Road
{
    private int length;
    private int width;
    private int numberOfLanes;
    private int currentTrafficLevel;

    public Road(int length, int width, int numberOfLanes)
    {
        this.length = length;
        this.width = width;
        this.numberOfLanes = numberOfLanes;
        this.currentTrafficLevel = 0;
    }

    public int GetLength()
    {
        return length;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetNumberOfLanes()
    {
        return numberOfLanes;
    }

    public int GetCurrentTrafficLevel()
    {
        return currentTrafficLevel;
    }

    public void SetCurrentTrafficLevel(int currentTrafficLevel)
    {
        this.currentTrafficLevel = currentTrafficLevel;
    }
}