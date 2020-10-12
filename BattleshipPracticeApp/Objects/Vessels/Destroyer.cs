using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Vessels
{
    class Destroyer : Vessel
    {
        public Destroyer(int id, string name)
        {
            ID = id;
            VesselName = name;
            Length = 4;
            NumberOfHits = 0;
            VesselSunk = false;
        }
    }
}
