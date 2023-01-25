namespace DOniciQGame
{
    partial class Game
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
            this.menuStrpGame = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfMoves = new System.Windows.Forms.Label();
            this.lblRemainingBoxes = new System.Windows.Forms.Label();
            this.txtbNumberMoves = new System.Windows.Forms.TextBox();
            this.txtbRemainingBoxes = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrpGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrpGame
            // 
            this.menuStrpGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrpGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrpGame.Location = new System.Drawing.Point(0, 0);
            this.menuStrpGame.Name = "menuStrpGame";
            this.menuStrpGame.Size = new System.Drawing.Size(1245, 24);
            this.menuStrpGame.TabIndex = 1;
            this.menuStrpGame.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // lblNumberOfMoves
            // 
            this.lblNumberOfMoves.AutoSize = true;
            this.lblNumberOfMoves.Location = new System.Drawing.Point(993, 74);
            this.lblNumberOfMoves.Name = "lblNumberOfMoves";
            this.lblNumberOfMoves.Size = new System.Drawing.Size(116, 16);
            this.lblNumberOfMoves.TabIndex = 2;
            this.lblNumberOfMoves.Text = "Number of moves:";
            // 
            // lblRemainingBoxes
            // 
            this.lblRemainingBoxes.AutoSize = true;
            this.lblRemainingBoxes.Location = new System.Drawing.Point(993, 132);
            this.lblRemainingBoxes.Name = "lblRemainingBoxes";
            this.lblRemainingBoxes.Size = new System.Drawing.Size(174, 16);
            this.lblRemainingBoxes.TabIndex = 3;
            this.lblRemainingBoxes.Text = "Number of remaining boxes:";
            // 
            // txtbNumberMoves
            // 
            this.txtbNumberMoves.Location = new System.Drawing.Point(996, 93);
            this.txtbNumberMoves.Name = "txtbNumberMoves";
            this.txtbNumberMoves.ReadOnly = true;
            this.txtbNumberMoves.Size = new System.Drawing.Size(173, 22);
            this.txtbNumberMoves.TabIndex = 4;
            // 
            // txtbRemainingBoxes
            // 
            this.txtbRemainingBoxes.Location = new System.Drawing.Point(994, 151);
            this.txtbRemainingBoxes.Name = "txtbRemainingBoxes";
            this.txtbRemainingBoxes.ReadOnly = true;
            this.txtbRemainingBoxes.Size = new System.Drawing.Size(173, 22);
            this.txtbRemainingBoxes.TabIndex = 4;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1064, 485);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(72, 56);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1064, 547);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(72, 56);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1142, 547);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 56);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(980, 547);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(78, 56);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(15, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(932, 722);
            this.panel.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 761);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtbRemainingBoxes);
            this.Controls.Add(this.txtbNumberMoves);
            this.Controls.Add(this.lblRemainingBoxes);
            this.Controls.Add(this.lblNumberOfMoves);
            this.Controls.Add(this.menuStrpGame);
            this.Controls.Add(this.panel);
            this.MainMenuStrip = this.menuStrpGame;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrpGame.ResumeLayout(false);
            this.menuStrpGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrpGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblNumberOfMoves;
        private System.Windows.Forms.Label lblRemainingBoxes;
        private System.Windows.Forms.TextBox txtbNumberMoves;
        private System.Windows.Forms.TextBox txtbRemainingBoxes;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Panel panel;
    }
}