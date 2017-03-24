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
        int paintCount = 0;
        public MineSweeperForm()
        {
            InitializeComponent();
            for(int i = 0; i < 100; i++)
            {
                Button newButton = new Button();
                buttons.Add(newButton);
            }
            
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

            //int newNumber = int.Parse(i.ToString() + base.ToString());
            //Button newButton = new Button();
            //buttons.Add(newButton);
            if(paintCount < 100)
            {
                Button button = buttons.ElementAt(paintCount);
                //This anchors the button to fill the entire panel slot
                button.Dock = (DockStyle.Fill);
                //newButton.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                //button.Visible = visibleStatus;
                button.Click += TileBtn_Click;
                //newButton.Click += new EventHandler(this.TileBtn_Click);
                tableLayoutPanel1.Controls.Add(button);
                //label4.Text = Convert.ToString(paintCount);
            }
            else
            {
                //paintCount = 0;
                //buttons.Clear();
                
            }
            paintCount++;


        //    bool visibleStatus = true;
        //    if (paintCount != 100)
        //    {
        //        label4.Text = Convert.ToString(paintCount);
        //        Button button = buttons.ElementAt(paintCount);
        //            //This anchors the button to fill the entire panel slot
        //            button.Dock = (DockStyle.Fill);
        //        //newButton.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        //        //button.Visible = visibleStatus;
        //            button.Click += TileBtn_Click;
        //            //newButton.Click += new EventHandler(this.TileBtn_Click);
        //            tableLayoutPanel1.Controls.Add(button);

        //}
        //    else
        //    {
        //        paintCount = 0;
        //        buttons.Clear();
        //        //MessageBox.Show("Overload");
        //    }


        //    //MessageBox.Show($"new button added");

        //    paintCount++;

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
            foreach (Button button in buttons)
            {
                //button.Visible = true;
                //If the spot clicked is within bounds of the button, do this
                if (button.Bounds.Contains(cursorPosition))
                {
                    label2.Text = "Found";
                    label3.Text = $"{buttons.IndexOf(button)}";
                    label4.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                    int tempIndex = buttons.IndexOf(button);
                    //button.Visible = false;
                    //tableLayoutPanel1.Controls.RemoveAt(tempIndex);
                    //label4.Text = Convert.ToString($"{tempIndex}");
                    //label4.Text = Convert.ToString(gameboard.Click(tempIndex));
                    //ChangeButton(tempIndex,Convert.ToInt32(gameboard.Click(tempIndex)));
                    
                    //button.Visible = false;
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

        //Method to change the visibilty of the button.
        int ChangeButton(int index, int status)
        {
            foreach (Button button in buttons)
            {
                if (buttons.IndexOf(button) == index)
                {
                    if (status == 0)
                    {
                        button.Visible = false;
                    }
                    return 0;
                }
            }
            return 1;
        }


    }
}
