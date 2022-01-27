using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyGame
{
    public  class StartMenu<T>
    {
       public static void Start()
        {
            
            Console.WriteLine("РПГ Битва-воинов");
            Console.WriteLine("\n \t ********** Добро пожаловать в игру **********");
            Thread.Sleep(1000);
            Console.WriteLine("\n Вы хотите запустить игру? Y. Я готов. N. Я снова думаю об этом");
            var Downkey = Console.ReadKey(true);
            if(Downkey.Key.Equals(ConsoleKey.N))
            {
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("\n\t ********** Увидемся в следющий раз, спасибо (^ _ ^) **********");
                 return;
                
            }
            
        }
    }
}
