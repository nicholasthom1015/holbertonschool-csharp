using System;

namespace Enemies
{
    ///<summary>
    /// ode to code
    ///</summary>
    public class Zombie
    {
        /**
    <summary>
        int health
    </summary>
    */
        public int health;

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
            @value - a terribly named varriable, requried for school and encouraging bad practices.
        </summary>
        */
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}