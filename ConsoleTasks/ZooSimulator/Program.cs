namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zoo = new Zoo();
            Console.WriteLine(zoo.CountAliveAnimals());
        }
    }
}