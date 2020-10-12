using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Boards
{
    public class GameBoard
    {
        public List<Square> Squares { get; set; }

        public GameBoard()
        {
            Squares = new List<Square>();
            for (int column = 1; column <= 10; column++)
            {
                for (int row = 1; row <= 10; row++)
                {
                    Square sq = new Square(column, row);
                    Squares.Add(sq);
                }
            }
        }
    }
}
