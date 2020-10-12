namespace BattleshipPracticeApp
{
    partial class frmGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            
            this.surrenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.cbRow = new System.Windows.Forms.ComboBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.bbAttack = new System.Windows.Forms.Button();
            this.rtxtGameText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem,
            
            this.surrenderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.ToolTipText = "Exit the game";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            //this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            //this.restartToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            //this.restartToolStripMenuItem.Text = "&Restart";
            //this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // surrenderToolStripMenuItem
            // 
            this.surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            this.surrenderToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.surrenderToolStripMenuItem.Text = "&Surrender";
            this.surrenderToolStripMenuItem.Click += new System.EventHandler(this.surrenderToolStripMenuItem_Click);
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Location = new System.Drawing.Point(535, 29);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(37, 21);
            this.cbColumn.TabIndex = 1;
            // 
            // cbRow
            // 
            this.cbRow.FormattingEnabled = true;
            this.cbRow.Location = new System.Drawing.Point(613, 29);
            this.cbRow.Name = "cbRow";
            this.cbRow.Size = new System.Drawing.Size(35, 21);
            this.cbRow.TabIndex = 2;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(487, 32);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(42, 13);
            this.lblColumn.TabIndex = 3;
            this.lblColumn.Text = "Column";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(578, 32);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(29, 13);
            this.lblRow.TabIndex = 4;
            this.lblRow.Text = "Row";
            // 
            // bbAttack
            // 
            this.bbAttack.Location = new System.Drawing.Point(654, 27);
            this.bbAttack.Name = "bbAttack";
            this.bbAttack.Size = new System.Drawing.Size(91, 23);
            this.bbAttack.TabIndex = 5;
            this.bbAttack.Text = "Attack!";
            this.bbAttack.UseVisualStyleBackColor = true;
            this.bbAttack.Click += new System.EventHandler(this.bbAttack_Click);
            // 
            // rtxtGameText
            // 
            this.rtxtGameText.Location = new System.Drawing.Point(12, 56);
            this.rtxtGameText.Name = "rtxtGameText";
            this.rtxtGameText.Size = new System.Drawing.Size(733, 382);
            this.rtxtGameText.TabIndex = 6;
            this.rtxtGameText.Text = "";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.rtxtGameText);
            this.Controls.Add(this.bbAttack);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.cbRow);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGame";
            this.Text = "Game Board";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surrenderToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.ComboBox cbRow;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button bbAttack;
        private System.Windows.Forms.RichTextBox rtxtGameText;
    }
}

