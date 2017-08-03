namespace humanapp
{
    public class Human
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string alias)
        {
            name = alias;
        }

        public Human(string alias, int str, int intl, int dex, int hp)
        {
            name = alias;
            strength = str;
            intelligence = intl;
            dexterity = dex;
            health = hp;
        }

        public void Attack(object enemy){
            Human foe = enemy as Human;
            if(enemy != null) {
            foe.health -= 5 * strength;
            }
        }
    }
}

