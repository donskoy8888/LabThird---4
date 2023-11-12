class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal lion = new Animal("Lion", 50, 5, 10);
        Animal rabbit = new Animal("Rabbit", 20, 2, 5);

        Plant tree = new Plant("Tree", 30, 15);
        Plant grass = new Plant("Grass", 5, 2);

        Microorganism bacteria = new Microorganism("Bacteria", 1, 1);

        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(rabbit);
        ecosystem.AddOrganism(tree);
        ecosystem.AddOrganism(grass);
        ecosystem.AddOrganism(bacteria);

        ecosystem.Simulate(10);
    }
}