using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.User
{
    interface IUser
    {
        int UserId { get; set; }
        bool IsHuman { get; set; }
        int ActiveTurn { get; set; }
    }
}
