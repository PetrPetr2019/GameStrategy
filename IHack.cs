﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyGame
{
    internal interface IHackPlayer : IWeapon
    {
        void Hask(); // Рубить
    }
}
