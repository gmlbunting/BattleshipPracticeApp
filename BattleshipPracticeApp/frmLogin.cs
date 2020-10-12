using BattleshipPracticeApp.Objects.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipPracticeApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void bbStartGame_Click(object sender, EventArgs e)
        {
            int turn;

            if (rdbFirst.Checked)
            {
                turn = 1;
            }
            else
            {
                turn = 2;
            }

            Player player = new Player(turn); //allows the growing of the game to two players and taking the first or second turn
            

            if (!string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                player.PlayerName = txtPlayerName.Text;
            }
            else 
            {
                MessageBox.Show("Please ensure you enter a name to continue", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                
            Hide();
            var newGame = new frmGame(player);
            newGame.ShowDialog();
            Close();
            
        }
    }
}
