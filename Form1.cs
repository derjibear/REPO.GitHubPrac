using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form


    {
        
        string player1Name;
        string dragon1Name;
        string player2Name;
        string dragon2Name;
        double player1Choice;
        double player2Choice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave1_Click(object sender, EventArgs e)

        {
            if (txtPlayer1Name.Text != "" && txtDragon1Name.Text != "")
            {
                player1Name = txtPlayer1Name.Text;
                dragon1Name = txtDragon1Name.Text;
                rtbLog.Text = "Player name:" + player1Name + "\n Dragon Name:" + dragon1Name + "\nplayer choice" + player1Choice;
            }
            else
            {
                rtbLog.Text = " you didnt enter names dimwit";
            }
            
        }

        private void radFire1_CheckedChanged(object sender, EventArgs e)
        {
            player1Choice = 1;
        }

        private void radIce1_CheckedChanged(object sender, EventArgs e)
        {
            player1Choice = 2;
        }

        private void gbx2_Enter(object sender, EventArgs e)
        {

        }

        private void radWind1_CheckedChanged(object sender, EventArgs e)
        {
            player1Choice = 3;
        }

        private void radEarth1_CheckedChanged(object sender, EventArgs e)
        {
            player1Choice = 4;
        }

        private void btnStart_Click(object sender, EventArgs e)

        {
            var Form2 = new Form2();
            this.Hide();
            Form2.ShowDialog();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if ( txtPlayer2Name.Text != "" && txtDragon2Name.Text != "")
            {
                player2Name = txtPlayer2Name.Text;
                dragon2Name = txtDragon2Name.Text;
                rtbLog2.Text = "Player name:" + player2Name + "\n Dragon Name:" + dragon2Name + "\nplayer choice";
            }
            else
            {
                rtbLog2.Text = " you didnt enter names dimwit";
            }
        }
    }
}
