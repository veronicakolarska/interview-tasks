namespace ZooSimulator
{
    public class Lion : Animal
    {
        public override bool IsDeath => this.Health < 50;
    }
}