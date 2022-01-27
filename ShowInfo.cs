using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace StrategyGame
{
    class ShowInfo : IHealtInformationWarrior
    {
        private readonly Random random = new Random();
        public int Health { get; set; } = 50;
        private double Wouds { get; set; }

        public virtual void Wounds()
        {
            var result = random.Next(1, 9);

            //var result = Equals(Health) == Equals(Dam);
            Console.WriteLine();
            if (result <= 3) Console.WriteLine($"Воин сдох:{Health / result}");
            else if (result >= 4) Console.WriteLine($"Воин жив:{Health / result}");
            Console.WriteLine();
            Console.WriteLine($"Здоровье вона:{Health / result} : Урон воина:{Wouds}{Health / result}");
        }

      

       
    }
}
