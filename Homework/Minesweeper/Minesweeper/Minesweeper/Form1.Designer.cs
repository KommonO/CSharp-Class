using System;

namespace Minesweeper
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
            this.statsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winLossRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tets2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsMenuItem,
            this.tets2ToolStripMenuItem,
            this.exitMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statsMenuItem
            // 
            this.statsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winLossRatioToolStripMenuItem,
            this.averageTimeToolStripMenuItem});
            this.statsMenuItem.Name = "statsMenuItem";
            this.statsMenuItem.Size = new System.Drawing.Size(78, 20);
            this.statsMenuItem.Text = "Game Stats";
            this.statsMenuItem.Click += new System.EventHandler(this.statsMenuItem_Click);
            // 
            // winLossRatioToolStripMenuItem
            // 
            this.winLossRatioToolStripMenuItem.Name = "winLossRatioToolStripMenuItem";
            this.winLossRatioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.winLossRatioToolStripMenuItem.Text = "Win/Loss Ratio";
            // 
            // averageTimeToolStripMenuItem
            // 
            this.averageTimeToolStripMenuItem.Name = "averageTimeToolStripMenuItem";
            this.averageTimeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.averageTimeToolStripMenuItem.Text = "Average Time";
            // 
            // tets2ToolStripMenuItem
            // 
            this.tets2ToolStripMenuItem.Name = "tets2ToolStripMenuItem";
            this.tets2ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.tets2ToolStripMenuItem.Text = "Restart Game";
            this.tets2ToolStripMenuItem.Click += new System.EventHandler(this.restartMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exitMenuItem.Text = "Exit Game";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(42, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 277);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tets2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winLossRatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageTimeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

