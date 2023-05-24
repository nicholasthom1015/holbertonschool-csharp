using System;

namespace Enemies
{
    ///<summary>
    /// Für Betty
    ///</summary>
    public class Zombie
    {
        private int health;
        private string name = null;
        ///<summary> Name Property </summary>
        public string Name
        {
            get { return name == null ? "(No name)" : name; }
            set { name = value; }
        }

        /**
        <summary>
            Default Constructor
        </summary>
        */
        public Zombie()
        {

        }

        /**
        <summary>
            specific Constructor
        </summary>
        <param name="value"> a terribly named varriable, should be more descriptive</param>
        */
        public Zombie(int value)
        {
            SetHealth(value);
        }

        /**
        <summary>
        Getter for health.
        </summary>
        <returns> the value of this.health </returns>
        */
        public int GetHealth()
        {
            return this.health;
        }

        private void SetHealth(int _health)
        {
            if (_health < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = _health;
        }
    }
}