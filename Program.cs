using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Human_1 = new Human("Chee");
            Wizard wizard = new Wizard("Pedro");
            System.Console.WriteLine(wizard.fireball(Human_1));
        }
    }
}
