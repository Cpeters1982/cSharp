namespace animalClass
{
    public abstract class Animal
    {
        public string name;
        public int legs;
        public int weight;

        public Animal(string n, int lbs, int legs)
        {
            this.name = n;
            this.legs = legs;
            this.weight = lbs;
        }

        public void speak()
        {
         System.Console.WriteLine("noise");
        }

        public void move()
        {
         System.Console.WriteLine("type");
        }    
    }
}

