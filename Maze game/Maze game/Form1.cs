using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
          
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations");
            Close();
        }
        private void MoveToStart()
            
        {
            Point startpoint = panel1.Location;
            Cursor.Position = PointToScreen(startpoint);





        }

        private Point PointToScreen(FormStartPosition StartPosition)
        {
            throw new NotImplementedException();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
