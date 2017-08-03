using System;

namespace wizNinSam
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name){
            health = 200;
        }

        public void deathBlow(object target){
            Human enemy = target as Human;
            if(enemy != null){
                if(enemy.health < 50) {
                    enemy.health = 0;
                }
            }
        }

        public void meditate(){
            health = 200;
        }
    }
}
