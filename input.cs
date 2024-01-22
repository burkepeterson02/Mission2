using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class input
    {
        public int rolls;
        public int GetCount()
        {
            System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
            System.Console.WriteLine("How many dice rolls would you like to simulate?\n");
            rolls = int.Parse(System.Console.ReadLine());
            return rolls;
        }
    }
}
