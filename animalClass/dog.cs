namespace animalClass
{
    class Dog : Animal
    {
       public Dog(string name, int weight, int legs):base("Dog", 10, 4){
           this.name = name;
           this.weight = weight;
           this.legs = legs;
       }

       public new void speak(){
           System.Console.WriteLine("Bark!");
       }

       public new void move(){
           System.Console.WriteLine("Run!");
       }
    }
}