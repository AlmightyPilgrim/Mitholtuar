using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier.RangedSubClasses
{
    public class Bow : Archer
    {
        public override void Attack()
        {
            int attack = 3;
            Console.WriteLine($"Attack power: {attack}");
        }
    }
}
