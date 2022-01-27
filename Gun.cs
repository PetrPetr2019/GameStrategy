using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    class Gun : IWeapon
    {
        Random rnd = new Random();
        public int Damage => rnd.Next(1, 110);
        public void Fire()
        {
            
            Console.WriteLine($"{GetType().Name}: Пух пух рух.\tУрон от стрельбы :{Damage}");
           
        }

       
    }
}
