namespace animalClass
{
    class Bird : Animal
    {
       public Bird(string name, int weight, int legs):base("Bird", 5, 2){
           this.name = name;
           this.weight = weight;
           this.legs = legs;
       }

       public new void speak(){
           System.Console.WriteLine("Chirp!");
       }

       public new void move(){
           System.Console.WriteLine("Fly!");
       }
    }
}