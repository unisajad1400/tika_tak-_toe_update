namespace tik_tak_toe2
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
        int ply;

        public Form1()
        {
            InitializeComponent();

            ply = 1;

            dokmeha = new Button[3, 3] { {button1, button2, button3},
                                         {button4, button5, button6},
                                         {button7, button8, button9}};
            new_game();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                    dokmeha[i, j].Text = "";

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Button this_button = (sender as Button);

            if (radioButton1.Checked == true)
            {
                if (this_button.Text == "")
                {
                    if (ply == 1)
                    {
                        this_button.Text = "X";
                        this_button.ForeColor = Color.Green;
                        this_button.BackColor = Color.LightGreen;
                        ply = 2;
                    }
                    else if (ply == 2)
                    {
                        this_button.Text = "0";
                        this_button.ForeColor = Color.Red;
                        this_button.BackColor = Color.Pink;
                        ply = 1;
                    }
                }
                if (row() == "X")
                {
                    MessageBox.Show("کاربر 1 برنده شده است");
                }
                else if (row() == "0")
                {
                    MessageBox.Show("کاربر 2 برنده شده است");
                }

                if (cloumn() == "X")
                {
                    MessageBox.Show("کاربر 1 برنده شده است");
                }
                else if (cloumn() == "0")
                {
                    MessageBox.Show("کاربر 2 برنده شده است");
                }
                diagonal();
            }

            else if (radioButton2.Checked == true)
            {
                if (this_button.Text == "")
                {
                    this_button.Text = "X";
                    this_button.ForeColor = Color.Green;
                    this_button.BackColor = Color.LightGreen;
                }
                user_Two();
            }
           
            if (row() == "X")
            {
                MessageBox.Show("کاربر 1 برنده شده است");
            }
            else if (row() == "0")
            {
                MessageBox.Show("کاربر 2 برنده شده است");
            }

            if (cloumn() == "X")
            {
                MessageBox.Show("کاربر 1 برنده شده است");
            }
            else if (cloumn() == "0")
            {
                MessageBox.Show("کاربر 2 برنده شده است");
            }
            diagonal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_game();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void new_game()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                }
            }

            ply = 1;
        }

        private string row()
        {
            int count = 0;
            int count2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dokmeha[i, j].Text == "X")
                    {
                        count++;
                    }
                    if (dokmeha[i, j].Text == "0")
                    {
                        count2++;
                    }
                }

                if (count == 3)
                {
                    return "X" ;
                }
                if (count2 == 3)
                {
                    return "0";
                }

                count = 0;
                count2 = 0;
            }

            return "";
        }

        private string cloumn()
        {
            int count = 0;
            int count2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dokmeha[j, i].Text == "X")
                    {
                        count++;
                    }

                    if (dokmeha[j, i].Text == "0")
                    {
                        count2++;
                    }
                }
                if (count == 3)
                {
                    return "X" ;
                }
                if (count2 == 3)
                {
                    return "0";
                }

                count = 0;
                count2 = 0;
            }
            return "";
        }

        private void diagonal()
        {
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده است");
            }
            else if (dokmeha[0, 0].Text == "0" && dokmeha[1, 1].Text == "0" && dokmeha[2, 2].Text == "0")
            {
                MessageBox.Show("بازیکن شماره 2 برنده است");
            }

            else if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده است");
            }
            else if (dokmeha[0, 2].Text == "0" && dokmeha[1, 1].Text == "0" && dokmeha[2, 0].Text == "0")
            {
                MessageBox.Show("بازیکن شماره 2 برنده است");
            }
        }

        private void user_Two()
        {
            int numberOne, numberTwo;

            Random r = new Random();
            Random r2 = new Random();

            while (true)
            {
                numberOne = r.Next(0, 3);
                numberTwo = r2.Next(0, 3);

                if (dokmeha[numberOne, numberTwo].Text == "" && dokmeha[numberOne, numberTwo].Text != "0" && dokmeha[numberOne, numberTwo].Text != "X")
                {
                    dokmeha[numberOne, numberTwo].Text = "0";
                    dokmeha[numberOne, numberTwo].ForeColor = Color.Red;
                    dokmeha[numberOne, numberTwo].BackColor = Color.Pink;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
            radioButton1.Enabled = false;
        }
    }
}