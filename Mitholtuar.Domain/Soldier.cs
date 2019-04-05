using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitholtuar.Domain
{
    public class Soldier
    {
        // virtual health, base health
        public virtual void Health()
        {
            int healthpool = 10;
        }

        // virtual attack power, base dmg
        //public virtual void Attack()
        //{
        //    int attack = 1;
        //}

        // virtual armor value, base armor value
        public virtual void Armor()
        {
            int armor = 0;
        }

        // virtual speed, base speed
        public virtual void speed()
        {
            int speed = 3;
        }
    }
}
