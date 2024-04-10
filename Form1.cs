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
        double player1Choice;
        double player2Choice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave1_Click(object sender, EventArgs e)

        {
            player1Name = txtPlayer1Name.Text;
            dragon1Name = txtDragon1Name.Text;
            rtbLog.Text = "Player name:" + player1Name + "\n Dragon Name:" + dragon1Name;
        }
    }
}
