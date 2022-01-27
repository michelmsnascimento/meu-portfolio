using System;


namespace desafioDio1.src.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "Write Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
