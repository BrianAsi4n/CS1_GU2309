using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = -1;
            int luot_dem = 3;
            TicTacToe game = new TicTacToe();
            game.play();
            do
            {
                Console.WriteLine("your option");
                key = int.Parse(Console.ReadLine());
            }
            while (key != 1 && key != 2 && key != 3);
           
        }
    }
}
