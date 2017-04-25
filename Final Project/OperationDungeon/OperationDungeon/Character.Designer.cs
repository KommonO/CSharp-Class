namespace OperationDungeon
{
    partial class Character
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.skillPointsBar = new System.Windows.Forms.ProgressBar();
            this.chooseAttackLabel = new System.Windows.Forms.Label();
            this.chooseAttackComboBox = new System.Windows.Forms.ComboBox();
            this.skillPointsLabel = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.healthValueLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.skillPointsBar);
            this.panel1.Controls.Add(this.chooseAttackLabel);
            this.panel1.Controls.Add(this.chooseAttackComboBox);
            this.panel1.Controls.Add(this.skillPointsLabel);
            this.panel1.Controls.Add(this.healthBar);
            this.panel1.Controls.Add(this.healthValueLabel);
            this.panel1.Controls.Add(this.healthLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // skillPointsBar
            // 
            this.skillPointsBar.Location = new System.Drawing.Point(87, 99);
            this.skillPointsBar.Name = "skillPointsBar";
            this.skillPointsBar.Size = new System.Drawing.Size(100, 10);
            this.skillPointsBar.TabIndex = 8;
            // 
            // chooseAttackLabel
            // 
            this.chooseAttackLabel.AutoSize = true;
            this.chooseAttackLabel.Location = new System.Drawing.Point(87, 4);
            this.chooseAttackLabel.Name = "chooseAttackLabel";
            this.chooseAttackLabel.Size = new System.Drawing.Size(77, 13);
            this.chooseAttackLabel.TabIndex = 7;
            this.chooseAttackLabel.Text = "Choose Attack";
            this.chooseAttackLabel.Visible = false;
            // 
            // chooseAttackComboBox
            // 
            this.chooseAttackComboBox.FormattingEnabled = true;
            this.chooseAttackComboBox.Location = new System.Drawing.Point(81, 28);
            this.chooseAttackComboBox.Name = "chooseAttackComboBox";
            this.chooseAttackComboBox.Size = new System.Drawing.Size(88, 21);
            this.chooseAttackComboBox.TabIndex = 6;
            this.chooseAttackComboBox.Visible = false;
            // 
            // skillPointsLabel
            // 
            this.skillPointsLabel.AutoSize = true;
            this.skillPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillPointsLabel.Location = new System.Drawing.Point(84, 83);
            this.skillPointsLabel.Name = "skillPointsLabel";
            this.skillPointsLabel.Size = new System.Drawing.Size(57, 13);
            this.skillPointsLabel.TabIndex = 4;
            this.skillPointsLabel.Text = "Skill Points";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(3, 99);
            this.healthBar.Minimum = 1;
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(71, 10);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 1;
            this.healthBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // healthValueLabel
            // 
            this.healthValueLabel.AutoSize = true;
            this.healthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthValueLabel.Location = new System.Drawing.Point(32, 83);
            this.healthValueLabel.Name = "healthValueLabel";
            this.healthValueLabel.Size = new System.Drawing.Size(46, 13);
            this.healthValueLabel.TabIndex = 2;
            this.healthValueLabel.Text = "100/100";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(-3, 83);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(40, 13);
            this.healthLabel.TabIndex = 1;
            this.healthLabel.Text = "Health:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Character";
            this.Size = new System.Drawing.Size(194, 111);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label healthLabel;
        public System.Windows.Forms.Label healthValueLabel;
        public System.Windows.Forms.ProgressBar healthBar;
        public System.Windows.Forms.Label chooseAttackLabel;
        public System.Windows.Forms.ComboBox chooseAttackComboBox;
        private System.Windows.Forms.Label skillPointsLabel;
        public System.Windows.Forms.ProgressBar skillPointsBar;
        //private System.Windows.Forms.ProgressBar healthBar;

    }
}
