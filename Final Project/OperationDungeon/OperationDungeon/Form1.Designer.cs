namespace OperationDungeon
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
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hero3 = new OperationDungeon.Character();
            this.enemy3 = new OperationDungeon.Character();
            this.enemy2 = new OperationDungeon.Character();
            this.enemy1 = new OperationDungeon.Character();
            this.hero2 = new OperationDungeon.Character();
            this.hero1 = new OperationDungeon.Character();
            this.attackBtn = new System.Windows.Forms.Button();
            this.defenseBtn = new System.Windows.Forms.Button();
            this.skillBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hero3);
            this.panel1.Controls.Add(this.enemy3);
            this.panel1.Controls.Add(this.enemy2);
            this.panel1.Controls.Add(this.enemy1);
            this.panel1.Controls.Add(this.hero2);
            this.panel1.Controls.Add(this.hero1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 364);
            this.panel1.TabIndex = 1;
            // 
            // hero3
            // 
            this.hero3.Location = new System.Drawing.Point(80, 233);
            this.hero3.Name = "hero3";
            this.hero3.Size = new System.Drawing.Size(75, 75);
            this.hero3.TabIndex = 6;
            // 
            // enemy3
            // 
            this.enemy3.Location = new System.Drawing.Point(542, 233);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(75, 75);
            this.enemy3.TabIndex = 5;
            // 
            // enemy2
            // 
            this.enemy2.Location = new System.Drawing.Point(542, 132);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(75, 75);
            this.enemy2.TabIndex = 4;
            // 
            // enemy1
            // 
            this.enemy1.Location = new System.Drawing.Point(542, 29);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(75, 75);
            this.enemy1.TabIndex = 3;
            // 
            // hero2
            // 
            this.hero2.Location = new System.Drawing.Point(80, 132);
            this.hero2.Name = "hero2";
            this.hero2.Size = new System.Drawing.Size(75, 75);
            this.hero2.TabIndex = 1;
            // 
            // hero1
            // 
            this.hero1.Location = new System.Drawing.Point(80, 29);
            this.hero1.Name = "hero1";
            this.hero1.Size = new System.Drawing.Size(75, 75);
            this.hero1.TabIndex = 0;
            // 
            // attackBtn
            // 
            this.attackBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.attackBtn.Location = new System.Drawing.Point(13, 398);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(75, 23);
            this.attackBtn.TabIndex = 2;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            // 
            // defenseBtn
            // 
            this.defenseBtn.Location = new System.Drawing.Point(94, 398);
            this.defenseBtn.Name = "defenseBtn";
            this.defenseBtn.Size = new System.Drawing.Size(75, 23);
            this.defenseBtn.TabIndex = 3;
            this.defenseBtn.Text = "Defense";
            this.defenseBtn.UseVisualStyleBackColor = true;
            // 
            // skillBtn
            // 
            this.skillBtn.Location = new System.Drawing.Point(175, 398);
            this.skillBtn.Name = "skillBtn";
            this.skillBtn.Size = new System.Drawing.Size(75, 23);
            this.skillBtn.TabIndex = 4;
            this.skillBtn.Text = "Skill";
            this.skillBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 428);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(708, 98);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 538);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.skillBtn);
            this.Controls.Add(this.defenseBtn);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Operation: Dungeon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button defenseBtn;
        private System.Windows.Forms.Button skillBtn;
        private System.Windows.Forms.TextBox textBox1;
        private Character enemy3;
        private Character enemy2;
        private Character hero2;
        private Character hero1;
        private Character hero3;
        private Character enemy1;
    }
}

