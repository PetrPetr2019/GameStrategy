using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    internal sealed class  Warrior<T1, T2> // Воин
    {
        internal T1 Name { get; set; }
        internal T2 Age { get; set; }

        internal Warrior(T1 name, T2 age)
        {
            Name = name;
            Age = age;
        }

        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowPlayer throwPlayer)
        {
            throwPlayer.Throw();
        }

        public void Hask(IHackPlayer hackPlayer)
        {
            hackPlayer.Hask();
        }

        public void Wounds(IHealtInformationWarrior information)
        {
            information.Wounds();
        }

        public void MaceStrike(MaceWarrior shilt)
        {
            shilt.MaceStrike();
        }

      public  void Choose(ISelectInventory selectInventory)
        {
            selectInventory.Choose();
        }
      public  void Enemy(IEnemy enemy)
        {
            enemy.Fight();
        }
    }
}
