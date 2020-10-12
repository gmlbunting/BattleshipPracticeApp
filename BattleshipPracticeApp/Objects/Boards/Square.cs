using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BattleshipPracticeApp.Objects.Coordinates;

namespace BattleshipPracticeApp.Objects.Boards
{
    public class Square
    {
        public Location coordinates { get; set; }
        public bool IsAttacked { get; set; }
        public int VesselId { get; set; }
        
        public Square(int column, int row)
        {
            coordinates = new Location(column, row);
            IsAttacked = false;
            VesselId = 0;
        }
    }

    public static class SquareEntensionMethods
    {
        public static List<Square> VesselArea(this List<Square> squares, int columnStart, int rowStart, int columnEnd, int rowEnd)
        {
            var vesselArea = squares.Where(x => x.coordinates.Column >= columnStart && x.coordinates.Column <= columnEnd && x.coordinates.Row >= rowStart && x.coordinates.Row <= rowEnd).ToList();
            return vesselArea;
        }
        public static Square FindSquare(this List<Square> squares, int column, int row)
        {
            var location = squares.Where(x => x.coordinates.Column == column && x.coordinates.Row == row).First();            
            return location;
        }

        public static void UpdateSquare(this List<Square> squares, int column, int row)
        {
            var location = squares.Where(x => x.coordinates.Column == column && x.coordinates.Row == row).First();
            location.IsAttacked = true;
        }
    }

}
