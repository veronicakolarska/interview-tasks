namespace ZooSimulator
{
    public abstract class Animal
    {
        public virtual int Health { get; set; } = 100;

        public abstract bool IsDeath { get; }

        public void GetHungry()
        {
            if (this.IsDeath)
            {
                return;
            }

            var randomHunger = new Random().Next(0, 20);
            this.Health -= randomHunger;
        }

        public void Feed()
        {
            if (this.IsDeath)
            {
                return;
            }

            var randomHealthGain = new Random().Next(5, 20);
            this.Health += randomHealthGain;
        }
    }
}