using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier.RangedSubClasses
{
    public class Crossbow : Archer
    {
        public override void Attack()
        {
            int attack = 5;
            Console.WriteLine($"Attack power: {attack}");
        }
    }
}
