namespace ZooSimulator
{
    public class Elephant : Animal
    {
        private int health = 100;
        private bool isDeath = false;

        public override int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (this.Health < 70 && value < 0)
                {
                    isDeath = true;
                }

                health = value;
            }
        }

        public override bool IsDeath => isDeath;
    }
}