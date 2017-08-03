using System;

namespace humanapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human one = new Human("Bruce Leroy",50,50,50,1000);
            Human two = new Human("Sho Nuff",50,50,50,1000);
            one.Attack(two);
            Console.WriteLine($"{one.name} knocked {two.name}'s health down to {two.health}");
        }
    }
}
