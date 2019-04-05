using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier.RangedSubClasses
{
    public class Javelin : Archer
    {
        public override void Attack()
        {
            int attack = 4;
            Console.WriteLine($"Attack power: {attack}");
        }
    }
}
