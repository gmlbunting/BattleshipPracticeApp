using BattleshipPracticeApp.Objects.Vessels;
using BattleshipPracticeApp.Objects.Boards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipPracticeApp.Objects.Game
{
    public enum GameResult
    {
        win = 1,
        loss = 2,
        tie = 3,
        undecided = 0,
    };

    public class Game
    {
        public int GameID { get; set; }
        public GameResult result { get; set; }
        public List<Vessel> Vessels { get; set; }
        public GameBoard GameBoard { get; set; }
        public int sunkCount { get; set; }

        public Game(int GameId)
        {
            GameID = GameId;
            result = 0;
            Vessels = new List<Vessel>();
            sunkCount = 0;
        }
    }

    public static class GameExtensionMethods
    {
        public static Vessel GetVessel(this List<Vessel> vessels,int vesselId)
        {
            var vessel = vessels.Where(x=>x.ID == vesselId).First();
            vessel.NumberOfHits++;
            if(vessel.NumberOfHits == vessel.Length)
            {
                vessel.VesselSunk = true;
            }
            return vessel;
        }
    }
}
