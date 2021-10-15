using System;

namespace cles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int i = 0;
            while(i<10)
            {
                i++;
            }
            Zombie zombie = new Zombie(100);
            
            while (zombie.Health > 0)
            {
                zombie.Health -= 10;
                Console.WriteLine(zombie.Health);
            }

            
            string adres;
            int leeftijd;
            Persoon persoon = new Persoon("Aidan","middel");
            
        }
    }
}
