using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier.MeleeSubClasses
{
    public class Sword : Melee
    {
        public override void Attack()
        {
            int attack = 3;
            Console.WriteLine($"Attack power: {attack}");
        }
    }
}
