using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    class Enemy : IEnemy // Враг
    {

       
        public int Damage => rnd.Next(1, 50);

       

        public int ChooseResult = 1;
        Random rnd = new Random();
      

        public void Fight()
        {
            var result = rnd.Next(1, 80);
            switch (ChooseResult)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Враг получил урона:{result}");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
        }
        public void ShowWisord()
        {
            Console.WriteLine("Выберите оружие Врага: Нажмите клавишу для  выбора оружия:  (1 / 2 / 3 / 4 / 5)");
            ChooseResult = Convert.ToInt32(Console.ReadLine());
            var inventory = new List<IWeapon>();
            var enemy = new Warrior<string, int>("Визор", rnd.Next(1, 300));
            
            switch (ChooseResult)
            {
                case 1:
                    Console.WriteLine($"Вы выбрали Пистолет\t Имя врага:{enemy.Name}:\tВозраст врага:{enemy.Age}\tУрон врага:{Damage}");
                    inventory.Add(new Gun());
                    enemy.Fire(new Gun());
                    enemy.Wounds(new ShowInfo());
                    enemy.Choose(new Protection());
                    enemy.Enemy(new Enemy());
                    break;
                case 2:
                    Console.WriteLine($"Вы выбрали Лазерную пушку\tИмя врага:{enemy.Name}:\tВозраст врага:{enemy.Age}\tУрон врага:{Damage}");
                    inventory.Add(new LazerGun());
                    enemy.Fire(new LazerGun());
                    enemy.Choose(new Protection());
                    enemy.Wounds(new ShowInfo());
                    enemy.Enemy(new Enemy());
                    break;
                case 3:
                    Console.WriteLine($"Вы выбрали Нож\tИмя врага:{enemy.Name}:\tВозраст врага:{enemy.Age}\tУрон врага:{Damage}");
                    inventory.Add(new Knife());
                    enemy.Fire(new Knife());
                    enemy.Throw(new Knife());
                    enemy.Choose(new Protection());
                   enemy.Enemy(new Enemy());
                    break;
                case 4:
                    Console.WriteLine($"Вы выбрали Меч\tИмя врага:{enemy.Name}:\tВозраст врага:{enemy.Age}\tУрон врага:{Damage}");
                    inventory.Add(new Sword());
                    enemy.Fire(new Sword());
                    enemy.Hask(new Sword());
                    enemy.Choose(new Protection());
                   enemy.Enemy(new Enemy());
                    break;
                case 5:
                    Console.WriteLine($"Вы выбрали Булаву\tИмя врага:{enemy.Name}:\tВозраст врага:{enemy.Age}\tУрон врага:{Damage}");
                    inventory.Add(new Mace());
                    enemy.Fire(new Mace());
                    enemy.MaceStrike(new Mace());
                    enemy.Choose(new Protection());
                    enemy.Enemy(new Enemy());
                    break;
                default:
                    Console.WriteLine("Пока такой защиты нет");
                    break;
            }

        }

       
    }
}
