using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StrategyGame
{
    internal class Mace : MaceWarrior // Булава воина
    {
        public int Damage => 4;
        internal int ChooseResult = 1;


        public void Fire() // Махать булавой 
        {
            Console.WriteLine($"{GetType().Name}:ууфть ууфть:\t\t Урон от взмаха булавы:{Damage}");
        }

        public void MaceStrike() // Удар булавой
        {
            Console.WriteLine($"{GetType().Name}:ууух ууух ууух:\t\t Урон от удара булавы:{Damage}");
        }
    }
}
