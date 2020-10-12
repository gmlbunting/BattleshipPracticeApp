using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Vessels
{
    public class Vessel
    {
        public int ID { get; set; }
        public string VesselName { get; set; }
        public int Length { get; set; }
        public int NumberOfHits { get; set; }
        public bool Orientation { get; set; } //0 vertical 1 horizontal
        public bool VesselSunk { get; set; }
    }
}
