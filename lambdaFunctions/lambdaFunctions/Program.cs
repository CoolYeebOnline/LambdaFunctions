using System;
using System.Linq;
using System.Collections.Generic;

namespace lambdaFunctions
{
    class Enemy
    {
        public string name { get; set; }
        public int health { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Enemys = new List<Enemy>()
            {
                new Enemy {name="Filip the fierce", health = 75 },
                new Enemy {name="Dadam the dastardly", health = 80 },
                new Enemy {name="Hari the breaker of walls", health = 95 },
                new Enemy {name ="Taylor the Tyrant", health = 90 },
                new Enemy {name = "Tom the cereal purchaser", health = 75 },
                new Enemy {name = "George the stranger", health = 45},
                new Enemy {name="Lord Dallon", health = 1000 }
            };

            IEnumerable<Enemy> trashmobs = Enemys.Where(p => p.health < 100);
            IEnumerable<Enemy> bossmobs = Enemys.Where(p => p.name.Contains("Lord"));

            IEnumerable<Enemy> trashmobsinorder = Enemys.Where(p => p.name.Contains("the")).OrderBy(p2 => p2.health < 45 ).ThenByDescending(p3=>p3.name.Length);

            Console.WriteLine("Trash mobs are: ");
            foreach (Enemy e in trashmobs)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\tHealth" + e.health);
            }

            Console.WriteLine("Trash mobs in order are: ");
            foreach (Enemy e in trashmobsinorder)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\tHealth" + e.health);
            }

            Console.WriteLine("Boss mobs are: ");
            foreach (Enemy e in bossmobs)
            {
                Console.WriteLine("\t" + e.name);
                Console.WriteLine("\tHealth" + e.health);
            }

            Console.ReadKey();
        }
    }
}
