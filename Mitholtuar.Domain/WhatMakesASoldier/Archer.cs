using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier
{
    public class Archer : Soldier
    { 

        public override void Armor()
        {
            int armor = 2;
        }

        public virtual void Attack()
        {
            int attack = 1;
        }

        public override void speed()
        {
            int speed = 4;
        }
    }
}
