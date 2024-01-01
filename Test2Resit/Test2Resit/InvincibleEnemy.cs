using System;
using System.Collections.Generic;
using System.Text;

namespace Test2Resit
{
    public class InvincibleEnemy:Enemy
    {
        public override void GetHit(int damage)
        {
            Console.WriteLine("Ha! Nice try");
        }
    }
}
