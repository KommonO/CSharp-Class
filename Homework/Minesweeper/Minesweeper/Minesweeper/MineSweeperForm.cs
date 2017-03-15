using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MineSweeperForm : Form
    {
        List<Button> buttons = new List<Button>();
        int nameIncrement = 0;
        Gameboard gameboard = new Gameboard();
        public MineSweeperForm()
        {
            InitializeComponent();
            
        }

        private void statsMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("stats clicked");
        }
        private void restartMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("restart clicked");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("exit clicked");
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("help clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the form is loaded, create a new game, which will create a new board or round.
            //Game game = new Game();
            //Gameboard gameboard = new Gameboard();
            //MessageBox.Show($"should be text : {Convert.ToString(gameboard.GetStatus(0,0))}");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawLine(System.Drawing.Pens.Red, tableLayoutPanel1.Left, tableLayoutPanel1.Top, tableLayoutPanel1.Right, tableLayoutPanel1.Bottom);

            //MessageBox.Show($"{this.Controls.Count}");

            //recursive for loop, concatenate the two, I and J, and set that button to dissappear in the list. 
            
            //int newNumber = int.Parse(i.ToString() + base.ToString());
            Button newButton = new Button();
            //newButton.Click += new EventHandler(this.TileBtn_Click);
            //newButton.Name = 
            buttons.Add(newButton);
            //This anchors the button to fill the entire panel slot
            newButton.Dock = (DockStyle.Fill);
            
            //newButton.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            newButton.Click += TileBtn_Click;
            tableLayoutPanel1.Controls.Add(newButton);

            
            
            //MessageBox.Show($"new button added");
            
            //newButton.Click += new EventHandler(this.TileBtn_Click);
            
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

            Graphics g = e.Graphics;
            //e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
            
        }
        void TileBtn_Click(Object sender, EventArgs e)
        {
            var cursorPosition = tableLayoutPanel1.PointToClient(Cursor.Position);
            label1.Text = cursorPosition.ToString();
            //label1.Text = Convert.ToString(GetChildAtPoint(cursorPosition));
            //label2.Text = $"Button.Left = {button.Left}";

            //foreach (Button button in tableLayoutPanel1.Controls)
            foreach (Button button in buttons)
            {
                //button.Visible = true;
                if (button.Bounds.Contains(cursorPosition))
                {
                    label2.Text = "Found";
                    label3.Text = $"{buttons.IndexOf(button)}";
                    int tempIndex = buttons.IndexOf(button);
                    //button.Visible = false;
                    //tableLayoutPanel1.Controls.RemoveAt(tempIndex);
                    label4.Text = gameboard.Click(tempIndex);
                }
                else
                {
                    //button.Visible = true;
                }
            }
            //GetChildAtPoint(cursorPosition).Visible = false;
            
           
            //Send Coordinates to the Game
            //Gameboard.SelectTile();//Need To Create method


            //Button clickedButton = (Button)sender;

            //clickedButton.Visible = false;
        }

       
    }
}
