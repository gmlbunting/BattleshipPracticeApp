using BattleshipPracticeApp.Objects.Boards;
using BattleshipPracticeApp.Objects.Coordinates;
using BattleshipPracticeApp.Objects.Game;
using BattleshipPracticeApp.Objects.User;
using BattleshipPracticeApp.Objects.Vessels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BattleshipPracticeApp
{
    public partial class frmGame : Form
    {
        private Player _player;
        private Opponent _opponent; //adding in the option to reuse this code to make it scalable to a true two player game
        private bool isQuitting = false;
        private int _turnCount; //can be used to limit guesses etc
        private Game _currentGame;
        private GameBoard _currentBoard;
        private int _sunkCount = 0;
        public frmGame(Player player)
        {
            InitializeComponent();
            _turnCount = 1;
            _player = player;
            cbRow.Enabled = false;
            cbColumn.Enabled = false;
            //_opponent = computer;
            //SelectVessels();
            var vessels = GenerateVesselLists();
            Game defaultGame = new Game(1);
            GameBoard gameBoard = new GameBoard();
            var returnedDefault = GenerateGame(defaultGame, gameBoard, vessels);
            _currentGame = returnedDefault.Item1;
            _currentBoard = returnedDefault.Item2;
            GenerateChoiceLists();
        }

        private List<Vessel> GenerateVesselLists()
        {
            List<Vessel> vessels = new List<Vessel>(); //seperated out generation to allow custom games in future
            Battleship queenElizabeth = new Battleship(1, "HMS Queen Elizabeth");
            Destroyer duncan = new Destroyer(2, "HMS Duncan");
            Destroyer defender = new Destroyer(3, "HMS Defender");
            vessels.Add(queenElizabeth);
            vessels.Add(duncan);
            vessels.Add(defender);
            return vessels;
        }

        private void GenerateChoiceLists()
        {
            List<ColumnItem> columns = new List<ColumnItem>();
            char ch = 'A';
            for(int i = 1; i <=10; i++)
            {                
                ColumnItem column = new ColumnItem();
                column.ColumnID = i;
                column.Letter = ch;
                ch++;
                columns.Add(column);
            }
            cbColumn.Enabled = true;
            cbColumn.DataSource = columns;
            cbColumn.DisplayMember = "Letter";
            cbColumn.ValueMember = "ColumnID";

            List<RowItem> rows = new List<RowItem>();
            for (int i = 1; i <= 10; i++)
            {
                RowItem row = new RowItem();
                row.RowID = i;
                rows.Add(row);
            }
            cbRow.Enabled = true;
            cbRow.DataSource = rows;
            cbRow.DisplayMember = "RowID";
            cbRow.ValueMember = "RowID";
        }

        private (Game,GameBoard) GenerateGame(Game game, GameBoard board,List<Vessel> vessels)
        {
            foreach (Vessel vessel in vessels) 
            {
                game.Vessels.Add(vessel);
                Random random = new Random();
                bool orientation = random.NextDouble() > 0.5;
                vessel.Orientation = orientation;
                PlaceVessel(vessel, board);
            }
            game.result = GameResult.undecided;
            return (game, board);
        }

        private void PlaceVessel(Vessel vessel, GameBoard gameBoard)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                int columnStart, rowStart, columnEnd, rowEnd;
                CalculateVesselsLocation(vessel, out columnStart, out rowStart, out columnEnd, out rowEnd);
                if (columnEnd > 10 || rowEnd > 10)
                {
                    keepGoing = true;
                    continue;
                }
                List<Square> vesselSquares = gameBoard.Squares.VesselArea(columnStart, rowStart, columnEnd, rowEnd);
                if (vesselSquares.Any(x => x.VesselId != 0))
                {
                    keepGoing = true;
                    continue;
                }
                foreach (Square square in vesselSquares)
                {
                    square.VesselId = vessel.ID;
                }
                keepGoing = false;
            }
        }

        private static void CalculateVesselsLocation(Vessel vessel, out int columnStart, out int rowStart, out int columnEnd, out int rowEnd)
        {
            Random random = new Random();
            columnStart = random.Next(1, 11);
            rowStart = random.Next(1, 11);
            rowEnd = rowStart;
            columnEnd = columnStart;
            Random random2 = new Random();
            bool columnOrRow = random2.NextDouble() > 0.5;            
            if (columnOrRow)
            {
                for (int i = 1; i < vessel.Length; i++)
                {
                    columnEnd++;
                }
            }
            else
            {
                for (int i = 1; i < vessel.Length; i++)
                {
                    rowEnd++;
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isQuitting = true;
            string message = "Are you sure you wish to quit the game, " + _player.PlayerName;
            string caption = "Quit";

            DialogResult quit = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            switch(quit)
            {
                case DialogResult.Yes:
                    Close();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!isQuitting)
            {
                string message = "Are you sure that you would like to close this game? " + _player.PlayerName;
                const string caption = "Closing";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void surrenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtGameText.AppendText("\nGame Over, you surrendered");
            _currentGame.result = GameResult.loss;
            bbAttack.Enabled = false;
        }

        private void bbAttack_Click(object sender, EventArgs e)
        {

            var chosenColumn = (int)cbColumn.SelectedValue;
            var chosenRow = (int)cbRow.SelectedValue;
            Move move = new Move();
            if (_turnCount > 100) //there are 100 squares max so limiting guesses to 100
            {
                return;
            }
            move.User = _player;
            move.Choice = new Location(chosenColumn, chosenRow);
            move.Turn = _turnCount;
            QueryGameboard(move, _currentBoard,_currentGame);
            CheckIfGameOver(_currentGame);
        }

        private void CheckIfGameOver(Game game)
        {
            if(game.sunkCount == game.Vessels.Count())
            {
                rtxtGameText.AppendText("\nGame Over, you win!");
                game.result = GameResult.win;
            }
        }

        private void QueryGameboard(Move currentMove,GameBoard board,Game game)
        {
            
            var selectedSquare = board.Squares.FindSquare(currentMove.Choice.Column, currentMove.Choice.Row);
            if (selectedSquare.IsAttacked)
            {
                rtxtGameText.AppendText("\nSquare Already Attacked");
                return;
            }            
            string print = $"\nCurrent Move {cbColumn.Text}{currentMove.Choice.Row}";
            rtxtGameText.AppendText(print);
            if (selectedSquare.VesselId != 0)
            {                
                var currentVessel = game.Vessels.GetVessel(selectedSquare.VesselId);
                rtxtGameText.AppendText("\nHIT!!");
                if (currentVessel.VesselSunk)
                {
                    string sunkMessage = $"\nyou sank the {currentVessel.VesselName}!!!!!!!";
                    rtxtGameText.AppendText(sunkMessage);
                    game.sunkCount++;
                }
            }
            else 
            {
                rtxtGameText.AppendText("\nOh thats a miss");
            }

            board.Squares.UpdateSquare(currentMove.Choice.Column, currentMove.Choice.Row);

            
        }
    }
}
