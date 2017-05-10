namespace OperationDungeon
{
    partial class ChooseCharacterControl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.characterPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Warrior",
            "Cleric",
            "Mage"});
            this.comboBox1.Location = new System.Drawing.Point(196, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // characterPreview
            // 
            this.characterPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterPreview.Location = new System.Drawing.Point(30, 15);
            this.characterPreview.Name = "characterPreview";
            this.characterPreview.Size = new System.Drawing.Size(75, 75);
            this.characterPreview.TabIndex = 0;
            this.characterPreview.TabStop = false;
            // 
            // ChooseCharacterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.characterPreview);
            this.Name = "ChooseCharacterControl";
            this.Size = new System.Drawing.Size(354, 115);
            ((System.ComponentModel.ISupportInitialize)(this.characterPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox characterPreview;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
