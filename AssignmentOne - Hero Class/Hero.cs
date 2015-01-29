using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne___Hero_Class
{
    class Hero
    {
        // PRIVATE PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private int strength;
        private int speed;
        private int health;
        private int hitStrength;
        

        // PUBLIC PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public string name;

        

        // CONSTRUCTOR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }

        
        // PRIVATE METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // random skill points generated from 0-100
        private void generateAbilities()
        {
            Random skillPts = new Random();
            this.strength = skillPts.Next(0, 100) + 1;
            this.speed = skillPts.Next(0, 100) + 1;
            this.health = skillPts.Next(0, 100) + 1;

        }
        // determines if hit is landed or not (3 = hit)
        private bool hitAttempt()
        {
            bool hit = false;
            Random attack = new Random();
            int attempt = attack.Next(1, 5) + 1;

            if (attempt == 3)
            {
                hit = true;
            }
            
            else
            {
                hit = false;
            }
            return hit;
        }

        // calculates amount of damage dealt to enemy (random number from 1-6)
        private int hitDamage()
        {
            Random damage = new Random ();
            this.hitStrength = this.strength * (damage.Next (0, 6) + 1);
            return hitStrength;
        }


        // PUBLIC METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void fight()
        {
            if (this.attempt == true)
            {
                hitDamage();
                Console.WriteLine ("{0} damage dealt!", this.hitStrength);
            }
            else
            {
                Console.WriteLine("You missed! Try again, Princess ;)");
            }
        }

        public void show()
        {
            Console.WriteLine("Princess Zelda's statistics:", this.name);
            Console.WriteLine("Strength {0}", this.strength);
            Console.WriteLine("Speed {0}", this.speed);
            Console.WriteLine("health {0}", this.health);
        }

        
        


    }
}
