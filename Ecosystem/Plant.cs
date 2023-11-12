class Plant : LivingOrganism, IReproducible
{
    private string species;
    public string Species
    {
        get { return species; }
        set { species = value; }
    }
    public Plant(string species, int energy, int size) : base(energy, 0, size)
    {
        Species = species;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Species} is reproducing.");
    }
}