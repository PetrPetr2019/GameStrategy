using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StrategyGame
{
    public class Protection : ISelectInventory // Щит
    {

        int ChooseResult = 1;

        public void Choose()
        {
            Console.WriteLine("Выберите инвентарь для защиты: Нажмите клавишу  (1 / 2 / 3 / 4)");
            ChooseResult = Convert.ToInt32(Console.ReadLine());
            switch (ChooseResult)
            {
                case 1:
                    Console.WriteLine("Вы выбрали деревянный щит");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали стальной щит");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали стальные доспехи");
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали стальные доспехи");
                    break;
                default:
                    Console.WriteLine("Пока такой защиты еще нет");
                    break;
            }
        }
    }
}

