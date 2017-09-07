using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        enum Direction { Right, Left, Up, Down };
        Direction direction = Direction.Right;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case Direction.Right:
                    label1.Left += 5;
                    break;
                case Direction.Down:
                    label1.Top += 5;
                    break;
                case Direction.Left:
                    label1.Left -= 5;
                    break;
                case Direction.Up:
                    label1.Top -= 5;
                    break;
            }

            if (label1.Left > ClientRectangle.Width - label1.Width)
            {
                direction = Direction.Down;
                label1.Left = ClientRectangle.Width - label1.Width;
            }

            if (label1.Top > ClientRectangle.Height - label1.Height)
            {
                direction = Direction.Left;
                label1.Top = ClientRectangle.Height - label1.Height;
            }

            if (label1.Left < 0 - label1.Width & direction == Direction.Left)
            {
                direction = Direction.Up;
                label1.Left = 0 - label1.Width;
            }

            if (label1.Top < 0 - label1.Height & direction == Direction.Up)
            {
                direction = Direction.Left;
                label1.Top = 0 - label1.Height;
            }
        }
    }
}
