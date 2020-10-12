using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Vessels
{
    class Battleship : Vessel
    {
       public Battleship(int id, string name)
        {
            ID = id;
            VesselName = name;
            Length = 5;
            NumberOfHits = 0;
            VesselSunk = false;
        }
    }
}
