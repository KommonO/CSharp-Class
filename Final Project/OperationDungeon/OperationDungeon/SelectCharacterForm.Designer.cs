namespace OperationDungeon
{
    partial class SelectCharacterForm
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
            this.characterSubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultCharacterSelect = new System.Windows.Forms.Button();
            this.chooseCharacterControl3 = new OperationDungeon.ChooseCharacterControl();
            this.chooseCharacterControl2 = new OperationDungeon.ChooseCharacterControl();
            this.chooseCharacterControl1 = new OperationDungeon.ChooseCharacterControl();
            this.SuspendLayout();
            // 
            // characterSubmitButton
            // 
            this.characterSubmitButton.Location = new System.Drawing.Point(70, 452);
            this.characterSubmitButton.Name = "characterSubmitButton";
            this.characterSubmitButton.Size = new System.Drawing.Size(230, 33);
            this.characterSubmitButton.TabIndex = 3;
            this.characterSubmitButton.Text = "Submit Character Selection";
            this.characterSubmitButton.UseVisualStyleBackColor = true;
            this.characterSubmitButton.Click += new System.EventHandler(this.characterSelectSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Your Squad!";
            // 
            // defaultCharacterSelect
            // 
            this.defaultCharacterSelect.Location = new System.Drawing.Point(133, 43);
            this.defaultCharacterSelect.Name = "defaultCharacterSelect";
            this.defaultCharacterSelect.Size = new System.Drawing.Size(93, 24);
            this.defaultCharacterSelect.TabIndex = 5;
            this.defaultCharacterSelect.Text = "Default";
            this.defaultCharacterSelect.UseVisualStyleBackColor = true;
            this.defaultCharacterSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseCharacterControl3
            // 
            this.chooseCharacterControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chooseCharacterControl3.Location = new System.Drawing.Point(12, 331);
            this.chooseCharacterControl3.Name = "chooseCharacterControl3";
            this.chooseCharacterControl3.Size = new System.Drawing.Size(354, 115);
            this.chooseCharacterControl3.TabIndex = 2;
            // 
            // chooseCharacterControl2
            // 
            this.chooseCharacterControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chooseCharacterControl2.Location = new System.Drawing.Point(13, 209);
            this.chooseCharacterControl2.Name = "chooseCharacterControl2";
            this.chooseCharacterControl2.Size = new System.Drawing.Size(354, 115);
            this.chooseCharacterControl2.TabIndex = 1;
            // 
            // chooseCharacterControl1
            // 
            this.chooseCharacterControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chooseCharacterControl1.Location = new System.Drawing.Point(12, 87);
            this.chooseCharacterControl1.Name = "chooseCharacterControl1";
            this.chooseCharacterControl1.Size = new System.Drawing.Size(354, 115);
            this.chooseCharacterControl1.TabIndex = 0;
            // 
            // SelectCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 511);
            this.Controls.Add(this.defaultCharacterSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.characterSubmitButton);
            this.Controls.Add(this.chooseCharacterControl3);
            this.Controls.Add(this.chooseCharacterControl2);
            this.Controls.Add(this.chooseCharacterControl1);
            this.Name = "SelectCharacterForm";
            this.Text = "Character Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChooseCharacterControl chooseCharacterControl1;
        private ChooseCharacterControl chooseCharacterControl2;
        private ChooseCharacterControl chooseCharacterControl3;
        private System.Windows.Forms.Button characterSubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button defaultCharacterSelect;
    }
}