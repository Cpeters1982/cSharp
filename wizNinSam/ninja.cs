using System;

namespace wizNinSam
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name){
            dexterity = 175;
        }

        public void steal(object target){
            Human enemy = target as Human;
            if(enemy != null) {
                health += 10;
            }
        }

        public void getAway(){
            health -= 15;
        }
    }
}
