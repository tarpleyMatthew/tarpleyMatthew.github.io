namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.anotherlabel = new System.Windows.Forms.Label();
            this.numP1Wins = new System.Windows.Forms.Label();
            this.numP2Wins = new System.Windows.Forms.Label();
            this.numDraws = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.resetWinCountToolStripMenuItem.Text = "Reset win count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.A1.Location = new System.Drawing.Point(26, 46);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(85, 85);
            this.A1.TabIndex = 1;
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_Click);
            this.A1.MouseEnter += new System.EventHandler(this.button_Enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.A2.Location = new System.Drawing.Point(117, 46);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(85, 85);
            this.A2.TabIndex = 2;
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_Click);
            this.A2.MouseEnter += new System.EventHandler(this.button_Enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.A3.Location = new System.Drawing.Point(208, 46);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(85, 85);
            this.A3.TabIndex = 3;
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_Click);
            this.A3.MouseEnter += new System.EventHandler(this.button_Enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B3.Location = new System.Drawing.Point(208, 137);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(85, 85);
            this.B3.TabIndex = 4;
            this.B3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_Click);
            this.B3.MouseEnter += new System.EventHandler(this.button_Enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B2.Location = new System.Drawing.Point(117, 137);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(85, 85);
            this.B2.TabIndex = 5;
            this.B2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_Click);
            this.B2.MouseEnter += new System.EventHandler(this.button_Enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.B1.Location = new System.Drawing.Point(26, 137);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(85, 85);
            this.B1.TabIndex = 6;
            this.B1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_Click);
            this.B1.MouseEnter += new System.EventHandler(this.button_Enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C1.Location = new System.Drawing.Point(26, 228);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(85, 85);
            this.C1.TabIndex = 7;
            this.C1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_Click);
            this.C1.MouseEnter += new System.EventHandler(this.button_Enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C2.Location = new System.Drawing.Point(117, 228);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(85, 85);
            this.C2.TabIndex = 8;
            this.C2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_Click);
            this.C2.MouseEnter += new System.EventHandler(this.button_Enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.C3.Location = new System.Drawing.Point(208, 228);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(85, 85);
            this.C3.TabIndex = 9;
            this.C3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_Click);
            this.C3.MouseEnter += new System.EventHandler(this.button_Enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1Label.Location = new System.Drawing.Point(33, 316);
            this.player1Label.MaximumSize = new System.Drawing.Size(73, 13);
            this.player1Label.MinimumSize = new System.Drawing.Size(73, 13);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(73, 13);
            this.player1Label.TabIndex = 10;
            this.player1Label.Text = "player1";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2Label.Location = new System.Drawing.Point(125, 317);
            this.player2Label.MaximumSize = new System.Drawing.Size(73, 13);
            this.player2Label.MinimumSize = new System.Drawing.Size(73, 13);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(73, 13);
            this.player2Label.TabIndex = 11;
            this.player2Label.Text = "player2";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anotherlabel
            // 
            this.anotherlabel.AutoSize = true;
            this.anotherlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anotherlabel.Location = new System.Drawing.Point(215, 316);
            this.anotherlabel.Name = "anotherlabel";
            this.anotherlabel.Size = new System.Drawing.Size(73, 13);
            this.anotherlabel.TabIndex = 12;
            this.anotherlabel.Text = "Draw Count";
            this.anotherlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numP1Wins
            // 
            this.numP1Wins.AutoSize = true;
            this.numP1Wins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numP1Wins.Location = new System.Drawing.Point(62, 340);
            this.numP1Wins.Name = "numP1Wins";
            this.numP1Wins.Size = new System.Drawing.Size(13, 13);
            this.numP1Wins.TabIndex = 13;
            this.numP1Wins.Text = "0";
            // 
            // numP2Wins
            // 
            this.numP2Wins.AutoSize = true;
            this.numP2Wins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numP2Wins.Location = new System.Drawing.Point(156, 340);
            this.numP2Wins.Name = "numP2Wins";
            this.numP2Wins.Size = new System.Drawing.Size(13, 13);
            this.numP2Wins.TabIndex = 14;
            this.numP2Wins.Text = "0";
            // 
            // numDraws
            // 
            this.numDraws.AutoSize = true;
            this.numDraws.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numDraws.Location = new System.Drawing.Point(245, 340);
            this.numDraws.Name = "numDraws";
            this.numDraws.Size = new System.Drawing.Size(13, 13);
            this.numDraws.TabIndex = 15;
            this.numDraws.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(320, 362);
            this.Controls.Add(this.numDraws);
            this.Controls.Add(this.numP2Wins);
            this.Controls.Add(this.numP1Wins);
            this.Controls.Add(this.anotherlabel);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 401);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label anotherlabel;
        private System.Windows.Forms.Label numP1Wins;
        private System.Windows.Forms.Label numP2Wins;
        private System.Windows.Forms.Label numDraws;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
    }
}

