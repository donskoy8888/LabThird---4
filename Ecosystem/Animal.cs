class Animal : LivingOrganism, IReproducible, IPredator
{
    private string species;
    public string Species
    {
        get { return species; }
        set { species = value; }
    }
    public Animal(string species, int energy, int age, int size) : base(energy, age, size)
    {
        Species = species;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Species} is reproducing.");
    }

    public void Hunt(LivingOrganism prey)
    {
        Console.WriteLine($"{Species} is hunting {prey.GetType().Name}.");
    }
}