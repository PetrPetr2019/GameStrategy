using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    class LazerGun : IWeapon

    {
        public int Damage => 12;
        
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Тьюю тьюю тьюю.\t Урон от лазерной пушки:{Damage}");
        }
    }
}
