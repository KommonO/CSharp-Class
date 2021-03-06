﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    public partial class SelectCharacterForm : Form
    {
        public string hero1Select;
        public string hero2Select;
        public string hero3Select;
        public SelectCharacterForm()
        {
            InitializeComponent();
        }

        private void chooseCharacterControl1_Load(object sender, EventArgs e)
        {

        }

        private void characterSelectSubmit_Click(object sender, EventArgs e)
        {

            
            //
            //Form1 form1 = new OperationDungeon.Form1();
            //form1.Show();
            //this.Visible = false;
            Console.WriteLine($"Number of forms : {Application.OpenForms.Count}");
            hero1Select = chooseCharacterControl1.stringType;
            hero2Select = chooseCharacterControl2.stringType;
            hero3Select = chooseCharacterControl3.stringType;
            string[] heroArray = new string[] {hero1Select,hero2Select,hero3Select };
            this.Hide();
            var form1 = new Form1(heroArray);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseCharacterControl1.comboBox1.SelectedIndex = 0;
            chooseCharacterControl2.comboBox1.SelectedIndex = 1;
            chooseCharacterControl3.comboBox1.SelectedIndex = 2;
            Console.WriteLine("Default button clicked");
        }
    }
}
