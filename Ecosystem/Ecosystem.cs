class Ecosystem
{
    private List<LivingOrganism> organisms = new List<LivingOrganism>();

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void Simulate(int timeSteps)
    {
        for (int i = 0; i < timeSteps; i++)
        {
            Console.WriteLine($"Time Step {i + 1}:");

            foreach (var organism in organisms)
            {
                if (organism is IReproducible reproducible)
                {
                    reproducible.Reproduce();
                }

                if (organism is IPredator predator)
                {
                    LivingOrganism prey = organisms.Find(o => o != organism);
                    predator.Hunt(prey);
                }

            }

            Console.WriteLine();
        }
    }
}