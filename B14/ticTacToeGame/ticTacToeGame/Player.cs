using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToeGame
{
    internal class Player
    {
        char sign;

        public Player(char sign='X')
        {
            this.sign = sign;
        }

        public char Sign { get => sign; set => sign = value; }

        public int takeTurn()
        {
            int fieldNumber = int.Parse(Console.ReadLine());
            return fieldNumber;
        }

        public bool checkSign(FIELD c1, FIELD c2,FIELD c3) 
        {
            return ((c1 == c2) && (c1 == c3) && c1 != FIELD.FLD_EMPTY);  
        }
        public bool checkRowsForWin(Board gameBoard)
        {
            for (int i = 0;i< Board.BOARD_SIZE; i++)
            {
                if (checkSign(gameBoard[i, 0].FielsState, gameBoard[i, 1].FielsState, gameBoard[i, 3].FielsState))
                return true;
            }
            return false;
        }
    }
}
