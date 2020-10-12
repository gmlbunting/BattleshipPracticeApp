using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.User
{
    public class Player : IUser
    {
        public int UserId { get; set; }
        public bool IsHuman { get; set; }
        public int ActiveTurn { get; set; }
        public string PlayerName { get; set; }
        public int Difficulty { get; set; } //can use this to change AI behavior if making it more scaleable

        public Player(int id)
        {
            UserId = id;
            IsHuman = true;
            ActiveTurn = 0;
            PlayerName = string.Empty;
        }
    }
}
