using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_toe
{
    public partial class Form2 : Form
    {
        private string PlayerName_1, PlayerName_2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            PlayerName_1 = Player1.Text; 
            PlayerName_2 = Player2.Text;
  
            var GameForm = new Form1(this, PlayerName_1, PlayerName_2);
            GameForm.Show();
            Program.Context.MainForm = GameForm;
            this.Close();   
        }
    }
}
