﻿using System;
namespace Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            Die dice = new Die();
            dice.RollDie();

            Board b = new Board();
            b.visBoard();
            Console.ReadKey();
        }

    }
}
