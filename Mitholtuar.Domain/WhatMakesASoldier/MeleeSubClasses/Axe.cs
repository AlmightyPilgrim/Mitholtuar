using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier.MeleeSubClasses
{
    public class Axe : Melee
    {
        public override void Attack()
        {
            int attack = 5;
            Console.WriteLine($"Attack power: {attack}");
        }
    }
}
