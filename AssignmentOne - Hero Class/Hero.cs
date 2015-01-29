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
        private bool attempt;
        private static Random randomNum = new Random(); // Generates random number


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
            this.strength = randomNum.Next(0, 100) + 1;
            this.speed = randomNum.Next(0, 100) + 1;
            this.health = randomNum.Next(0, 100) + 1;

        }
        // determines if hit is landed or not (20%)
        private bool hitAttempt()
        {
            if (randomNum.Next (0, 100)<=20)
            {
                this.attempt = true;
            }
            else
            {
                this.attempt = false;
            }
            return this.attempt;
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
            Console.WriteLine("|_|^|_|^|_|^|_|^_|^|_|^|_|^|_|");
            Console.WriteLine("Princess Zelda's statistics:", this.name);
            Console.WriteLine("Strength {0}", this.strength);
            Console.WriteLine("Speed {0}", this.speed);
            Console.WriteLine("health {0}", this.health);
            Console.WriteLine("|____________________________|");
        }

        
        


    }
}
