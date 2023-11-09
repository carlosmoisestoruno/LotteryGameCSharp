using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryGame
{
    public partial class Stage : Form
    {
        private int[] cards = new int[54];
        public Stage()
        {
            InitializeComponent();
        }

        private void Stage_Load(object sender, EventArgs e)
        {

        }

        private void btnNextCard_Click(object sender, EventArgs e)
        {
            //picBox1.Image = Properties.Resources._1;
            //picBox2.Image = Properties.Resources._2;
            //picBox3.Image = Properties.Resources._3;
        }

        private void btnShuffel_Click(object sender, EventArgs e)
        {

        }

        private void btnGetDeck_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
