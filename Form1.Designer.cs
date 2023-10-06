namespace Pig_Roller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p1ScoreBox = new System.Windows.Forms.TextBox();
            this.p2ScoreBox = new System.Windows.Forms.TextBox();
            this.PigsRolledBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1OverallScore = new System.Windows.Forms.TextBox();
            this.p2OverallScore = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.p1GamesWon = new System.Windows.Forms.TextBox();
            this.p2GamesWon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GamesPlayed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Pig_Roller.Properties.Resources.PassThePig;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // p1ScoreBox
            // 
            resources.ApplyResources(this.p1ScoreBox, "p1ScoreBox");
            this.p1ScoreBox.BackColor = System.Drawing.SystemColors.Control;
            this.p1ScoreBox.Name = "p1ScoreBox";
            this.p1ScoreBox.ReadOnly = true;
            // 
            // p2ScoreBox
            // 
            resources.ApplyResources(this.p2ScoreBox, "p2ScoreBox");
            this.p2ScoreBox.BackColor = System.Drawing.SystemColors.Control;
            this.p2ScoreBox.Name = "p2ScoreBox";
            this.p2ScoreBox.ReadOnly = true;
            // 
            // PigsRolledBox
            // 
            resources.ApplyResources(this.PigsRolledBox, "PigsRolledBox");
            this.PigsRolledBox.Name = "PigsRolledBox";
            this.PigsRolledBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpRulesToolStripMenuItem,
            this.pointSystemToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // helpRulesToolStripMenuItem
            // 
            resources.ApplyResources(this.helpRulesToolStripMenuItem, "helpRulesToolStripMenuItem");
            this.helpRulesToolStripMenuItem.Name = "helpRulesToolStripMenuItem";
            this.helpRulesToolStripMenuItem.Click += new System.EventHandler(this.helpRulesToolStripMenuItem_Click);
            // 
            // pointSystemToolStripMenuItem
            // 
            resources.ApplyResources(this.pointSystemToolStripMenuItem, "pointSystemToolStripMenuItem");
            this.pointSystemToolStripMenuItem.Name = "pointSystemToolStripMenuItem";
            this.pointSystemToolStripMenuItem.Click += new System.EventHandler(this.pointSystemToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // p1OverallScore
            // 
            resources.ApplyResources(this.p1OverallScore, "p1OverallScore");
            this.p1OverallScore.BackColor = System.Drawing.SystemColors.Window;
            this.p1OverallScore.Name = "p1OverallScore";
            this.p1OverallScore.ReadOnly = true;
            // 
            // p2OverallScore
            // 
            resources.ApplyResources(this.p2OverallScore, "p2OverallScore");
            this.p2OverallScore.Name = "p2OverallScore";
            this.p2OverallScore.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // p1GamesWon
            // 
            resources.ApplyResources(this.p1GamesWon, "p1GamesWon");
            this.p1GamesWon.Name = "p1GamesWon";
            this.p1GamesWon.ReadOnly = true;
            // 
            // p2GamesWon
            // 
            resources.ApplyResources(this.p2GamesWon, "p2GamesWon");
            this.p2GamesWon.Name = "p2GamesWon";
            this.p2GamesWon.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // GamesPlayed
            // 
            resources.ApplyResources(this.GamesPlayed, "GamesPlayed");
            this.GamesPlayed.Name = "GamesPlayed";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.GamesPlayed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p2GamesWon);
            this.Controls.Add(this.p1GamesWon);
            this.Controls.Add(this.p2OverallScore);
            this.Controls.Add(this.p1OverallScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PigsRolledBox);
            this.Controls.Add(this.p2ScoreBox);
            this.Controls.Add(this.p1ScoreBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox p1ScoreBox;
        private System.Windows.Forms.TextBox p2ScoreBox;
        private System.Windows.Forms.TextBox PigsRolledBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointSystemToolStripMenuItem;
        private System.Windows.Forms.TextBox p1OverallScore;
        private System.Windows.Forms.TextBox p2OverallScore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox p1GamesWon;
        private System.Windows.Forms.TextBox p2GamesWon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GamesPlayed;
    }
}
