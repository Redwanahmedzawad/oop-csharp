using System;

namespace Test2Resit
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena();
            arena.Attack(5);
            arena.Attackall(3);


            arena.AddEnemy(new RegularEnemy());
            arena.AddEnemy(new RegularEnemy());
            arena.AddEnemy(new RegularEnemy());
            arena.AddEnemy(new InvincibleEnemy());

            arena.Attack(10);
            arena.Attackall(1);

        }
    }
}
