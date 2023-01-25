namespace DOniciQGame
{
    partial class Design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Design));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRowsColumns = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtbColumns = new System.Windows.Forms.TextBox();
            this.txtbRows = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.pnlRowsColumns.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeMenuItem.Text = "Close";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // pnlRowsColumns
            // 
            this.pnlRowsColumns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRowsColumns.Controls.Add(this.btnGenerate);
            this.pnlRowsColumns.Controls.Add(this.txtbColumns);
            this.pnlRowsColumns.Controls.Add(this.txtbRows);
            this.pnlRowsColumns.Controls.Add(this.lblColumns);
            this.pnlRowsColumns.Controls.Add(this.lblRows);
            this.pnlRowsColumns.Location = new System.Drawing.Point(0, 25);
            this.pnlRowsColumns.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRowsColumns.Name = "pnlRowsColumns";
            this.pnlRowsColumns.Size = new System.Drawing.Size(1125, 56);
            this.pnlRowsColumns.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.Location = new System.Drawing.Point(395, 12);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(147, 30);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtbColumns
            // 
            this.txtbColumns.Location = new System.Drawing.Point(246, 15);
            this.txtbColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtbColumns.Name = "txtbColumns";
            this.txtbColumns.Size = new System.Drawing.Size(132, 20);
            this.txtbColumns.TabIndex = 2;
            // 
            // txtbRows
            // 
            this.txtbRows.Location = new System.Drawing.Point(49, 15);
            this.txtbRows.Margin = new System.Windows.Forms.Padding(2);
            this.txtbRows.Name = "txtbRows";
            this.txtbRows.Size = new System.Drawing.Size(132, 20);
            this.txtbRows.TabIndex = 2;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(191, 20);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(59, 15);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(8, 20);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(41, 15);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // pnlTools
            // 
            this.pnlTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTools.Controls.Add(this.btnGreenBox);
            this.pnlTools.Controls.Add(this.btnRedBox);
            this.pnlTools.Controls.Add(this.btnGreenDoor);
            this.pnlTools.Controls.Add(this.btnRedDoor);
            this.pnlTools.Controls.Add(this.btnWall);
            this.pnlTools.Controls.Add(this.btnNone);
            this.pnlTools.Controls.Add(this.lblToolBox);
            this.pnlTools.Location = new System.Drawing.Point(0, 85);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(182, 525);
            this.pnlTools.TabIndex = 2;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Image = ((System.Drawing.Image)(resources.GetObject("btnGreenBox.Image")));
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.Location = new System.Drawing.Point(20, 329);
            this.btnGreenBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(112, 50);
            this.btnGreenBox.TabIndex = 1;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Image = ((System.Drawing.Image)(resources.GetObject("btnRedBox.Image")));
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.Location = new System.Drawing.Point(20, 275);
            this.btnRedBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(112, 50);
            this.btnRedBox.TabIndex = 1;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Image = ((System.Drawing.Image)(resources.GetObject("btnGreenDoor.Image")));
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.Location = new System.Drawing.Point(20, 221);
            this.btnGreenDoor.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(112, 50);
            this.btnGreenDoor.TabIndex = 1;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Image = ((System.Drawing.Image)(resources.GetObject("btnRedDoor.Image")));
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.Location = new System.Drawing.Point(20, 162);
            this.btnRedDoor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(112, 55);
            this.btnRedDoor.TabIndex = 1;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnWall
            // 
            this.btnWall.Image = ((System.Drawing.Image)(resources.GetObject("btnWall.Image")));
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.Location = new System.Drawing.Point(20, 104);
            this.btnWall.Margin = new System.Windows.Forms.Padding(2);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(112, 54);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.Image = ((System.Drawing.Image)(resources.GetObject("btnNone.Image")));
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.Location = new System.Drawing.Point(20, 46);
            this.btnNone.Margin = new System.Windows.Forms.Padding(2);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(112, 54);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolBox.Location = new System.Drawing.Point(32, 14);
            this.lblToolBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(100, 20);
            this.lblToolBox.TabIndex = 0;
            this.lblToolBox.Text = "Toolbox";
            // 
            // Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 718);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlRowsColumns);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Design";
            this.Text = "QGame Design";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlRowsColumns.ResumeLayout(false);
            this.pnlRowsColumns.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRowsColumns;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtbColumns;
        private System.Windows.Forms.TextBox txtbRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}