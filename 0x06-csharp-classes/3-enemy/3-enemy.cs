using System;

namespace Enemies
{
    ///<summary>Represents Zombie class</summary>
    class Zombie
    {
        private int _health;

        public Zombie()
        {
            _health = 0;
        }
        public Zombie(int value)
        {
            _health = value;
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        public int GetHealth()
        {
            return _health;
        }
    }
}
