using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    class Knife : IThrowPlayer
    {
        public int Damage => 4;
        int ChooseResult = 1;
       

        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Хать хать хать.\t урон от удара ножом:{Damage}");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Фьють фьють фьють.\t урон от киданиеи ножа:{Damage}");

        }


    }
}
