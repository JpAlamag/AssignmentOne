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

        // PUBLIC PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public string name;

        

        // CONSTRUCTOR ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public Hero(string name)
        {
            this.name = name;
        }

        
        // PRIVATE METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        
        private void generateAbilities()
        {
            Random skillPts = new Random();
            this.strength = skillPts.Next(0, 100);
            this.speed = skillPts.Next(0, 100);
            this.health = skillPts.Next(0, 100);

        }

      /*  private bool hitAttempt()
        {
            // switch statement random num
        }

        
        private int hitDamage()
        {

        }


        // PUBLIC METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void fight()
        {

        }

        public show()
        {

        }*/

        
        


    }
}
