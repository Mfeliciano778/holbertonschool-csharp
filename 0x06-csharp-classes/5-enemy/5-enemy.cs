using System;

namespace Enemies
{
    class Zombie
    {
        public int health;

        private string name = "(No name)";

        public string Name
        {
            get => name;
            set => name = value;
        }
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        public int GetHealth()
        {
            return health;
        }

        public override string ToString()
        {
            return "Zombie Name: " + this.name + " / Total Health: " + this.health;
        }
    }
}
