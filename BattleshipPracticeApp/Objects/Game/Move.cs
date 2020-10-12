using BattleshipPracticeApp.Objects.Coordinates;
using BattleshipPracticeApp.Objects.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Game
{
    class Move
    {
        //set up for two player game expansion
        public IUser User { get; set; }
        public Location Choice { get; set; }
        public int Turn { get; set; }
    }
}
