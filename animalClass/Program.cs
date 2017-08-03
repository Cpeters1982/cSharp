using System;

namespace animalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog one = new Dog("Wiley", 50, 4);
            Bird two = new Bird("Roadrunner", 20, 2);
            one.speak();
            one.move();
            two.speak();
            two.move();
        }
    }
}
