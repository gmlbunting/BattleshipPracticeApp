namespace BattleshipPracticeApp
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.bbStartGame = new System.Windows.Forms.Button();
            this.grpPlayWhen = new System.Windows.Forms.GroupBox();
            this.rdbSecond = new System.Windows.Forms.RadioButton();
            this.rdbFirst = new System.Windows.Forms.RadioButton();
            this.grpPlayWhen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(11, 15);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(84, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(150, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // bbStartGame
            // 
            this.bbStartGame.Location = new System.Drawing.Point(159, 116);
            this.bbStartGame.Name = "bbStartGame";
            this.bbStartGame.Size = new System.Drawing.Size(75, 23);
            this.bbStartGame.TabIndex = 2;
            this.bbStartGame.Text = "Start Game!";
            this.bbStartGame.UseVisualStyleBackColor = true;
            this.bbStartGame.Click += new System.EventHandler(this.bbStartGame_Click);
            // 
            // grpPlayWhen
            // 
            this.grpPlayWhen.Controls.Add(this.rdbSecond);
            this.grpPlayWhen.Controls.Add(this.rdbFirst);
            this.grpPlayWhen.Location = new System.Drawing.Point(84, 38);
            this.grpPlayWhen.Name = "grpPlayWhen";
            this.grpPlayWhen.Size = new System.Drawing.Size(150, 72);
            this.grpPlayWhen.TabIndex = 3;
            this.grpPlayWhen.TabStop = false;
            this.grpPlayWhen.Text = "Play:";
            // 
            // rdbSecond
            // 
            this.rdbSecond.AutoSize = true;
            this.rdbSecond.Enabled = false;
            this.rdbSecond.Location = new System.Drawing.Point(18, 43);
            this.rdbSecond.Name = "rdbSecond";
            this.rdbSecond.Size = new System.Drawing.Size(62, 17);
            this.rdbSecond.TabIndex = 1;
            this.rdbSecond.TabStop = true;
            this.rdbSecond.Text = "Second";
            this.rdbSecond.UseVisualStyleBackColor = true;
            // 
            // rdbFirst
            // 
            this.rdbFirst.AutoSize = true;
            this.rdbFirst.Checked = true;
            this.rdbFirst.Location = new System.Drawing.Point(18, 20);
            this.rdbFirst.Name = "rdbFirst";
            this.rdbFirst.Size = new System.Drawing.Size(44, 17);
            this.rdbFirst.TabIndex = 0;
            this.rdbFirst.TabStop = true;
            this.rdbFirst.Text = "First";
            this.rdbFirst.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 152);
            this.Controls.Add(this.grpPlayWhen);
            this.Controls.Add(this.bbStartGame);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.grpPlayWhen.ResumeLayout(false);
            this.grpPlayWhen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button bbStartGame;
        private System.Windows.Forms.GroupBox grpPlayWhen;
        private System.Windows.Forms.RadioButton rdbSecond;
        private System.Windows.Forms.RadioButton rdbFirst;
    }
}