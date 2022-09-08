namespace ZooSimulator
{
    public class Monkey : Animal
    {
        public override bool IsDeath => this.Health < 40;
    }
}