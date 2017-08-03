using System;

namespace wizNinSam
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name){
            intelligence = 25;
            health = 50;
        }

        public void heal(){
            health += 10 * intelligence;
        }

        public void fireball(object target){
            Human enemy = target as Human;
            if(enemy != null) {
                Random rand = new Random();
                enemy.health -= rand.Next(20,51);
            }
        }
    }
}