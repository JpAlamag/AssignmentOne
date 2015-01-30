using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: John Paul Alamag - 300792027
 * Program: Assignment One - Hero Class
 * Date last modified: 1/30/2015
 * Revision History: Minor edits to make program asthetically pleasing
 */
namespace AssignmentOne___Hero_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implemented Hero class
            Hero myhero = new Hero("Zelda");
            myhero.show();
            Console.WriteLine();
            myhero.fight();
        }
    }
}
