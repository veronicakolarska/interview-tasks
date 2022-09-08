namespace ZooSimulator
{
    public class Zoo
    {
        public IEnumerable<Animal> Animals { get; set; } = new List<Animal>();

        public Zoo()
        {
            var lions = Enumerable.Range(0, 5).Select(x => new Lion());
            var elephants = Enumerable.Range(0, 5).Select(x => new Elephant());
            var monkeys = Enumerable.Range(0, 5).Select(x => new Monkey());

            var animals = new List<Animal>();
            animals.AddRange(lions);
            animals.AddRange(elephants);
            animals.AddRange(monkeys);
            this.Animals = animals;
        }

        public int CountAliveAnimals()
        {
            return this.Animals.Count(a => !a.IsDeath);
        }
    }
}