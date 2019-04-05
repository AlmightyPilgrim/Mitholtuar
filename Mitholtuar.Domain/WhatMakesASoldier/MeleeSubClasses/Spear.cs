using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier.MeleeSubClasses
{
    public class Spear : Melee
    {
        public override void Attack()
        {
            int attack = 2;
            Console.WriteLine($"Attack power: {attack}");
        }
    }
}
