using System;

namespace StrategyGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            StartMenu<int>.Start();
          
           LogicWarrior logicWarrior = new LogicWarrior();
           logicWarrior.Choose();
            Enemy Enemy = new Enemy();
            Enemy.ShowWisord();
        }


    }
}
