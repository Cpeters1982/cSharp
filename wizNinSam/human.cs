using System;

namespace wizNinSam
{
    public class Human
    {
        public string name;
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Human(string alias)
        {
            name = alias;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string alias, int str, int intl, int dex, int hp)
        {
            name = alias;
            strength = str;
            intelligence = intl;
            dexterity = dex;
            health = hp;
        }

        public void attack(object enemy){
            Human foe = enemy as Human;
            if(enemy != null) {
            foe.health -= 5 * strength;
            }
        }
    }
}

