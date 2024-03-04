using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac11
{
    public class Monster
    {
        static Random rnd = new Random();
        static string[] haract = new string[5] { "Добрый", "Славный", "Кусачий", "Злой", "Бешеный" };
        static string[] names = new string[5] { "Гоблин", "Рыцарь", "Злыдень", "Водяной", "Воин" };

        public string name;
        int hp;
        private double armor;
        int damage;
        
        public Monster()
        {
            CreateName();
            SetHp();
            SetArmor(armor);
            SetDamage(damage, damage);
        }
        
        public string CreateName()
        {
            name = names[rnd.Next(names.Length)] + " " + haract[rnd.Next(haract.Length)];
            return name;
        }
        public int GetHp()
        {
            return hp;
        }

        public void SetHp()
        {
            hp = rnd.Next(90, 100);
        }

        public double GetArmor()
        {
            return armor;
        }

        public void SetArmor(double a)
        {
            armor = a;
        }

        public int GetDamage()
        {
            return damage;
        }

        public void SetDamage(int a, int b)
        {
            damage = rnd.Next(a, b);
        }

        public bool Attack()
        {
            return rnd.Next(4) != 0;
        }

        public void Hit(int dmg)
        {
            hp -= dmg;
        }

        public void DrawMonster()
        {
            Console.WriteLine($"◘--------{name}");
            Console.WriteLine($"| Здоровье {hp}");
            Console.WriteLine($"| Урон: {damage}");
            Console.WriteLine($"◘----------------------");
        }
    }
}