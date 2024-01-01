using System;
using System.Collections.Generic;
using System.Text;

namespace Test2Resit
{
    public class Arena
    {
        private List<Enemy> _enemies = new List<Enemy>();
        public Arena()
        {

        }
        public void AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
        }
        public void Attack(int damage)
        {
            if (_enemies.Count > 0)
            {
                Console.WriteLine("Bring it on!");
                _enemies[0].GetHit(damage);
            }
            else
            {
                Console.WriteLine("Not very effective...");
            }
        }
        public void Attackall(int damage)
        {
            if (_enemies.Count > 0)
            {
                Console.WriteLine("Charge!");
                foreach (Enemy e in _enemies){
                    e.GetHit(damage);
                }
            }
            else
            {
                Console.WriteLine("There is nobody here...");
            }
        }
    }
}
