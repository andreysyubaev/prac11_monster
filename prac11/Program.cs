using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monster1 = new Monster();
            monster1.DrawMonster();
            Console.WriteLine();

            Console.WriteLine("ПРОТИВ");
            Console.WriteLine();

            Monster monster2 = new Monster();
            monster2.DrawMonster();

            Console.WriteLine("enter");
            Console.ReadKey();
            Console.WriteLine();
            while (monster1.GetHp() > 1 && monster2.GetHp() > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                if (monster1.Attack())
                {
                    monster2.Hit(monster1.GetDamage());
                    Console.WriteLine($"{monster1.name} наносит {monster1.GetDamage()} урона {monster2.name}");
                }
                else
                {
                    Console.WriteLine($"{monster1.name} промахивается");
                }

                if (monster2.GetHp() > 1)
                {
                    if (monster2.Attack())
                    {
                        monster1.Hit(monster2.GetDamage());
                        Console.WriteLine($"{monster2.name} наносит {monster2.GetDamage()} урона {monster1.name}.");
                    }
                    else
                    {
                        Console.WriteLine($"{monster2.name} промахивается");
                    }
                }

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                //monster1.Hit(monster1.GetDamage());
                //monster2.Hit(monster1.GetDamage());

                monster1.DrawMonster();
                monster2.DrawMonster();

                Console.ReadKey();
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("бой окончен!");
            Console.ResetColor();

            if (monster1.GetHp() < 1 && monster2.GetHp() < 1)
            {
                Console.WriteLine();
                Console.WriteLine($"НИЧЬЯ! ");
            }
            else if (monster1.GetHp() > monster2.GetHp())
            {
                Console.WriteLine();
                Console.WriteLine($"ПОБЕДИЛ: ");
                monster1.DrawMonster();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"ПОБЕДИЛ: ");
                monster2.DrawMonster();
            }

            Console.Read();
        }
    }
}
