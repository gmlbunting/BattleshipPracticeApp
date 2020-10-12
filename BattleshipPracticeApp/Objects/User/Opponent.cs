using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.User
{
    class Opponent : IUser
    {
        public int UserId { get; set; }
        public bool IsHuman { get; set; }
        public int ActiveTurn { get; set; }
        public string OpponentName { get; set; }

        public Opponent(int id)
        {
            UserId = id;
            IsHuman = false;
            ActiveTurn = 0;
            OpponentName = "Computer";
        }
    }
}
