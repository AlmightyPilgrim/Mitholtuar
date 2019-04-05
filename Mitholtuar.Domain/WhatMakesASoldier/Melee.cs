using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier
{
    class Melee : Soldier
    {
        public override void Health()
        {
            int healthpool = 15;
        }

        public override void Armor()
        {
            int armor = 4;
        }

        public virtual void Attack()
        {
            int attack = 1;
        }

        public override void speed()
        {
            int speed = 2;
        }
    }
}
