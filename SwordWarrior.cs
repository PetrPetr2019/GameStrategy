using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    class Sword:IHackPlayer // Мечь
    {
        Random rnd = new Random();
        public int Damage => rnd.Next(1, 80) ;
        
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}:Ат ат ат ат ат.\t\tУрон от удара меча:{Damage}");
        }

        public virtual void Hask() // Рубить
        {
            Console.WriteLine($"{GetType().Name}:Щщщлях щщлях щщлях.\tУрон от рубки меча:{Damage} ");
        }
    }
}
