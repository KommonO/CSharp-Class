using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    public partial class ChooseCharacterControl : UserControl
    {
        public string stringType;
        public ChooseCharacterControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //read in string
            ComboBox character = (ComboBox)sender;
            string stringSelect = character.Text;
            MessageBox.Show($"Selected{stringSelect} of type {stringSelect.GetType()}");
            SetPreviewImage(stringSelect);
        }
        private void SetPreviewImage(string characterType)
        {
            switch (characterType)
            {
                case "Warrior":
                    Console.WriteLine("Character to background change = Warrior");
                    characterPreview.BackgroundImage = System.Drawing.Image.FromFile(@"Warrior.png");
                    stringType = "Warrior";
                    break;
                case "Mage":
                    Console.WriteLine("Character to background change = Mage");
                    characterPreview.BackgroundImage = System.Drawing.Image.FromFile(@"Mage.png");
                    stringType = "Mage";
                    break;
                case "Cleric":
                    Console.WriteLine("Character to background change = Cleric");
                    characterPreview.BackgroundImage = System.Drawing.Image.FromFile(@"Cleric.png");
                    stringType = "Cleric";
                    break;
            }
        }
    }
}
