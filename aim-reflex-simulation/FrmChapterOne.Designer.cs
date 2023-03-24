namespace aim_reflex_simulation
{
    partial class FrmChapterOne
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChapterOne));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxCenter = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblDeneme = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapter1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapter1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chapter1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chapter1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.BtnStart.Location = new System.Drawing.Point(422, 636);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(108, 34);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.BtnStop.Location = new System.Drawing.Point(536, 636);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(108, 34);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(99)))), ((int)(((byte)(10)))));
            this.BtnRestart.Location = new System.Drawing.Point(650, 636);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(108, 34);
            this.BtnRestart.TabIndex = 2;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeft.Image")));
            this.pictureBoxLeft.Location = new System.Drawing.Point(76, 167);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(312, 318);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeft.TabIndex = 3;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxCenter
            // 
            this.pictureBoxCenter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCenter.Image")));
            this.pictureBoxCenter.Location = new System.Drawing.Point(417, 167);
            this.pictureBoxCenter.Name = "pictureBoxCenter";
            this.pictureBoxCenter.Size = new System.Drawing.Size(312, 318);
            this.pictureBoxCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCenter.TabIndex = 4;
            this.pictureBoxCenter.TabStop = false;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRight.Image")));
            this.pictureBoxRight.Location = new System.Drawing.Point(764, 167);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(312, 318);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRight.TabIndex = 5;
            this.pictureBoxRight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblDeneme
            // 
            this.LblDeneme.AutoSize = true;
            this.LblDeneme.Location = new System.Drawing.Point(257, 549);
            this.LblDeneme.Name = "LblDeneme";
            this.LblDeneme.Size = new System.Drawing.Size(35, 13);
            this.LblDeneme.TabIndex = 6;
            this.LblDeneme.Text = "label1";
            this.LblDeneme.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaptersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chapter1ToolStripMenuItem,
            this.chapter1ToolStripMenuItem1,
            this.chapter1ToolStripMenuItem2,
            this.chapter1ToolStripMenuItem3});
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.chaptersToolStripMenuItem.Text = "Chapters";
            // 
            // chapter1ToolStripMenuItem
            // 
            this.chapter1ToolStripMenuItem.Name = "chapter1ToolStripMenuItem";
            this.chapter1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chapter1ToolStripMenuItem.Text = "Chapter 1";
            this.chapter1ToolStripMenuItem.Click += new System.EventHandler(this.chapter1ToolStripMenuItem_Click);
            // 
            // chapter1ToolStripMenuItem1
            // 
            this.chapter1ToolStripMenuItem1.Name = "chapter1ToolStripMenuItem1";
            this.chapter1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chapter1ToolStripMenuItem1.Text = "Chapter 2";
            this.chapter1ToolStripMenuItem1.Click += new System.EventHandler(this.chapter1ToolStripMenuItem1_Click);
            // 
            // chapter1ToolStripMenuItem2
            // 
            this.chapter1ToolStripMenuItem2.Name = "chapter1ToolStripMenuItem2";
            this.chapter1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.chapter1ToolStripMenuItem2.Text = "Chapter 3";
            // 
            // chapter1ToolStripMenuItem3
            // 
            this.chapter1ToolStripMenuItem3.Name = "chapter1ToolStripMenuItem3";
            this.chapter1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.chapter1ToolStripMenuItem3.Text = "Chapter 4";
            // 
            // FrmChapterOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(188)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1199, 704);
            this.Controls.Add(this.LblDeneme);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxCenter);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmChapterOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 1";
            this.Load += new System.EventHandler(this.FrmChapterOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxCenter;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblDeneme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapter1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapter1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chapter1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem chapter1ToolStripMenuItem3;
    }
}

