using System;

namespace wizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wiz = new Wizard("Babidi");
            Ninja nin = new Ninja("Shinobi");
            Samurai sam = new Samurai("Musashi");
            wiz.fireball(sam);
            Console.WriteLine($"{wiz.name} used FIREBALL on {sam.name}. {sam.name}'s health decreased to {sam.health}!");
            nin.getAway();
            System.Console.WriteLine($"{nin.name} used GET AWAY. took 15 damage!");
            sam.meditate();
            System.Console.WriteLine($"{sam.name} used MEDITATE. restored health back to {sam.health}!");
            nin.attack(wiz);
            System.Console.WriteLine($"{nin.name} used ATTACK on {wiz.name}. {wiz.name}' took 15 damage!");
            sam.deathBlow(wiz);
            System.Console.WriteLine($"{sam.name} used DEATHBLOW on {wiz.name}. {wiz.name}'s health decreased to {wiz.health}!");
        }
    }
}
