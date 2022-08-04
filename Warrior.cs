using WarrriorWars.Enum;
using WarrriorWars.Equipment;

namespace WarrriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;
        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }


        private Weapon weapon;
        private Armour armour;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;

            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armour = new Armour(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armour = new Armour(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }

        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armour.AmourPoints;

            enemy.health = enemy.health - damage;

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Console.WriteLine($"{enemy.name} is dead!, {name} wins");
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. damage inflicted to {enemy.name}, remaining health is {enemy.health}");
            }
        }
    }
}
