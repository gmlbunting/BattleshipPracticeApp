using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Coordinates
{
    public class Location
    {
        public int Column { get; set; }
        public int Row { get; set; }

        public Location(int column, int row)
        {
            Column = column;
            Row = row;
        }
    }
}
