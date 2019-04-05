using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain.WhatMakesASoldier
{
    public class Melee : Soldier
    {
        public override void Health()
        {
            int healthpool = 15;
            Console.WriteLine($"Health: {healthpool}");
        }

        public override void Armor()
        {
            int armor = 4;
            Console.WriteLine($"Armor value: {armor}");
        }

        public virtual void Attack()
        {
            int attack = 1;
        }

        public override void speed()
        {
            int speed = 2;
            Console.WriteLine($"Speed: {speed}");
        }
    }
}
