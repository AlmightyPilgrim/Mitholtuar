using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier
{
    class Spearman : Soldier
    {
        public override void Health()
        {
            int healthpool = 15;
        }

        public override void Armor()
        {
            int armor = 3;
        }
    }
}
