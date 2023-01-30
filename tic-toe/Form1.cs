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
    public partial class Form1 : Form
    {
        private int CurrentPlayer = 1;
        private string name1, name2;
        private Button[] buttons = new Button[9];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form form2, string name1, string name2)
        {
            InitializeComponent();
            PlayerName1.Text = name1;
            PlayerName2.Text = name2;
            this.name1 = name1;
            this.name2 = name2;
            PlayerName1.ForeColor = Color.Red;

            foreach(var btn in flowLayoutPanel1.Controls)
            {
                buttons[i] = (Button)btn;
                i++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (CurrentPlayer)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    sender.GetType().GetProperty("BackColor").SetValue(sender, Color.Red);
                    CurrentPlayer = 0;
                    PlayerName1.ForeColor = Color.Black;
                    PlayerName2.ForeColor = Color.Red;
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "0");
                    sender.GetType().GetProperty("BackColor").SetValue(sender, Color.Green);
                    CurrentPlayer = 1;
                    PlayerName2.ForeColor = Color.Black;
                    PlayerName1.ForeColor = Color.Red;
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            if (CheckWin())
            {
                MessageBox.Show($"игрок {(CurrentPlayer == 0 ? name1 : name2)} Победил", "Winner");
                Reset();
            }

        }

        private bool CheckWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
                return true;
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                return true;
            else if (button8.Text == button7.Text && button7.Text == button9.Text && button7.Text != "" )
                return true;
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                return true;
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                return true;
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                return true;
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                return true;
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                return true;
            return false;

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            foreach(var btn in buttons)
            {
                btn.Text = "";
                btn.Enabled = true;
                btn.BackColor = Color.White;
                string tmp = name1;
                name1 = name2;
                name2 = tmp;
                PlayerName1.Text = PlayerName1.Text == name1 ? name2 : name1;
                PlayerName2.Text = PlayerName1.Text == name1 ? name2 : name1;
                PlayerName1.ForeColor = Color.Red; PlayerName2.ForeColor = Color.Black;
                CurrentPlayer = 1;
            }
        }

    }
}
