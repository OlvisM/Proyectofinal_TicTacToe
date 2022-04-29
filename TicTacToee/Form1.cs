using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean cheker;
        int plusone;

        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")

            {
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button2.BackColor = System.Drawing.Color.SteelBlue;
                button3.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")

            {
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button4.BackColor = System.Drawing.Color.SteelBlue;
                button7.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")

            {
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")

            {
                button2.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button8.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")

            {
                button3.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button7.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")

            {
                button3.BackColor = System.Drawing.Color.SteelBlue;
                button6.BackColor = System.Drawing.Color.SteelBlue;
                button9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")

            {
                button4.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button6.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")

            {
                button7.BackColor = System.Drawing.Color.SteelBlue;
                button8.BackColor = System.Drawing.Color.SteelBlue;
                button9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num1.Text);
                Num1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //.....................................................................................................................//

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")

            {
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button2.BackColor = System.Drawing.Color.SteelBlue;
                button3.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")

            {
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button4.BackColor = System.Drawing.Color.SteelBlue;
                button7.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")

            {
                button1.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")

            {
                button2.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button8.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")

            {
                button3.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button7.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")

            {
                button3.BackColor = System.Drawing.Color.SteelBlue;
                button6.BackColor = System.Drawing.Color.SteelBlue;
                button9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")

            {
                button4.BackColor = System.Drawing.Color.SteelBlue;
                button5.BackColor = System.Drawing.Color.SteelBlue;
                button6.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")

            {
                button7.BackColor = System.Drawing.Color.SteelBlue;
                button8.BackColor = System.Drawing.Color.SteelBlue;
                button9.BackColor = System.Drawing.Color.SteelBlue;

                MessageBox.Show("The winner is player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(Num2.Text);
                Num2.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button1.Text = "X";
                cheker = true;
            }
            else
            {
                button1.Text = "O";
                cheker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button2.Text = "X";
                cheker = true;
            }
            else
            {
                button2.Text = "O";
                cheker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button3.Text = "X";
                cheker = true;
            }
            else
            {
                button3.Text = "O";
                cheker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button4.Text = "X";
                cheker = true;
            }
            else
            {
                button4.Text = "O";
                cheker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button5.Text = "X";
                cheker = true;
            }
            else
            {
                button5.Text = "O";
                cheker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button6.Text = "X";
                cheker = true;
            }
            else
            {
                button6.Text = "O";
                cheker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button7.Text = "X";
                cheker = true;
            }
            else
            {
                button7.Text = "O";
                cheker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button8.Text = "X";
                cheker = true;
            }
            else
            {
                button8.Text = "O";
                cheker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cheker == false)
            {
                button9.Text = "X";
                cheker = true;
            }
            else
            {
                button9.Text = "O";
                cheker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;


                Num2.Text = "0";
                Num1.Text = "0";

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult button12;
                button12 = MessageBox.Show("Confirn if you want to exit", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (button12 == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-PVNQ7PKM;user id=Mejia1;password=Mejia#2004;Initial Catalog=Game;Integrated Security=True");
            Con.Open();
            string Nm = "INSERT INTO Game ([X],[O])" +
                " values ('"+Num1.Text+"' , '"+Num2.Text+"')" ;
            SqlCommand con = new SqlCommand(Nm,Con);
            con.ExecuteNonQuery();
           

            Con.Close();


        }

        private void Num2_Click(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object sender, EventArgs e)
        {

        }
    }
}
