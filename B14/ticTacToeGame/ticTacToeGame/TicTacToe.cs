using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToeGame
{
    internal class TicTacToe
    {
      public TicTacToe() { }
        public void play()
        {
            int moveCounter = 0;
            Board gameBoard = new Board();
            Player playerX = new Player('X');
            Player playerY = new Player('Y');

            Player currentPlayer = playerX;
            bool play = true;
                while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("player {0} enter the field in which you want to put the number",currentPlayer);
                try
                {
                    int turn = currentPlayer.takeTurn();
                  if(! gameBoard.putMark(currentPlayer.Sign, turn))
                        xulySai();
                  gameBoard.clearBoard();
                    moveCounter++;
                    if(currentPlayer.checkRowsForWin(gameBoard) )
                    {
                        Console.WriteLine("player {0} win!",currentPlayer.Sign);
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if(moveCounter == 9)
                    {
                        Console.WriteLine("draw!");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? 
                }catch(Exception e)
                {
                    xulySai();
                }
            }
        }
        public void xulySai()
        {
            Console.WriteLine("invalid input");
            Console.ReadLine();
            Console.Clear();
        }
    }
   
}
