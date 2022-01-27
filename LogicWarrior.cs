using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    public  class LogicWarrior:ISelectInventory // выбор инвенторя воина
    {

        public int ChooseResult = 1;
        Random rnd = new Random();
        public  void Choose()
        {

            var warrior1 = new Warrior<string, int>("Бальтазар", rnd.Next(1, 300));
            //var warrior2 = new Warrior<string, int>("Святогор", 120);
         
          
            //IWeapon[] Inventory = { new Gun(), new Knife(), new LazerGun(),new Sword(),  new Mace() };
            
            ////
            Console.WriteLine("Выберите оружие: Нажмите клавишу  (1 / 2 / 3 / 4 / 5)");
            try
            {
              ChooseResult = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Введите данные");
                Console.ReadLine();
                var inventory = new List<IWeapon>();


                switch (ChooseResult)
                {
                    case 1:
                        Console.WriteLine(
                            $"Вы выбрали пистолет\t Имя воина:{warrior1.Name}:\tВозраст воина:{warrior1.Age}");
                        inventory.Add(new Gun());
                        warrior1.Fire(new Gun());
                        warrior1.Wounds(new ShowInfo());
                        warrior1.Choose(new Protection());

                        break;
                    case 2:

                        Console.WriteLine($"Вы выбрали лазерный пистолет \t Имя воина:{warrior1.Name}:\tВозраст воина:{warrior1.Age}");
                        inventory.Add(new LazerGun());
                        warrior1.Fire(new LazerGun());
                        warrior1.Choose(new Protection());
                        warrior1.Wounds(new ShowInfo());
                        break;
                    case 3:
                        Console.WriteLine($"Вы выбрали Нож \t Имя воина:{warrior1.Name}:\tВозраст воина:{warrior1.Age}");
                        inventory.Add(new Knife());
                        warrior1.Fire(new Knife());
                        warrior1.Throw(new Knife());
                        warrior1.Choose(new Protection());
                        break;
                    case 4:
                        Console.WriteLine($"Вы выбрали мець кладинец \t Имя воина:{warrior1.Name}:\tВозраст воина:{warrior1.Age}");
                        inventory.Add(new Sword());
                        warrior1.Fire(new Sword());
                        warrior1.Hask(new Sword());
                        warrior1.Choose(new Protection());
                        break;
                    case 5:
                        Console.WriteLine($"Вы выбрали булаву \t Имя воина:{warrior1.Name}:\tВозраст воина:{warrior1.Age}");
                        inventory.Add(new Mace());
                        warrior1.Fire(new Mace());
                        warrior1.MaceStrike(new Mace());
                        warrior1.Choose(new Protection());
                        break;
                    default:
                        Console.WriteLine("Пока такой защиты нет");
                        break;
                }

            }
           
        }
          
         

    }
}


