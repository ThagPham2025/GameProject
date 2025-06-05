using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Project_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Name = Console.ReadLine();
            Console.WriteLine(hero.Name);

            Item item = new Item();
            Weapon weapon = new Weapon();

            Enemy enemy = new Enemy();
            enemy.TakeDamage(hero.CalculateDamage());

        }
        class Enemy
        {
            public string Name;
            public int HP = 50;
            public int ATK = 5;

            public Inventory inventory;

            public void TakeDamage(int damage)
            {
                HP -= damage;
            }

        }
        class Hero
        {
            public string Name;
            public int HP = 100;
            public int Mana = 100;
            public int ATK = 5;
            public Weapon Weapon;

            public Inventory inventory;

            public int CalculateDamage()
            {
                if (Weapon != null)
                {
                    return ATK + Weapon.ATK;
                }
                else
                {
                    return ATK;
                }
            }

            public void TakeDamage(int damage)
            {
                HP -= damage;
            }

        }
        class Inventory
        {
            public List<Item> items = new List<Item>();
            public int maxSlots = 10;


        }
        class Item
        {

        }

        class Weapon : Item
        {
            public string Sword;
            public int ATK;

            public Weapon(string Sword = "Sword", int ATK = 20)
            {
                this.Sword = Sword; ;
                this.ATK = ATK;
            }

        }
        class Shirt : Item
        {
            public string shirt;
            public int arrmor, hpPlus;

            public Shirt(string shirt = "Shirt", int arrmor = 0, int hpPlus = 0)
            {
                this.shirt = shirt;
                this.arrmor = arrmor;
                this.hpPlus = hpPlus;
            }
        }
        class Shoes : Item
        {
            public string shoes;
            public int arrmor, hpPlus;

            public Shoes(string shoes = "Shoes", int arrmor = 5, int hpPlus = 50)
            {
                this.shoes = shoes;
                this.arrmor = arrmor;
                this.hpPlus = hpPlus;
            }
        }
        class Hat : Item
        {
            public string hat;
            public int arrmor, hpPlus;

            public Hat(string hat = "Hat", int arrmor = 10, int hpPlus = 10)
            {
                this.hat = hat;
                this.arrmor = arrmor;
                this.hpPlus = hpPlus;
            }
        }
        class Trouser : Item
        {
            public string trouser;
            public int arrmor, hpPlus;

            public Trouser(string trouser = "Trouser", int arrmor = 5, int hpPlus = 0)
            {
                this.trouser = trouser;
                this.arrmor = arrmor;
                this.hpPlus = hpPlus;
            }
        }

        class Posion : Item
        {
            public string posion;
            public int healValue;

            public Posion(string posion = "HPPosion", int healValue = 20)
            {
                this.posion = posion;
                this.healValue = healValue;
            }
        }

    }
}
