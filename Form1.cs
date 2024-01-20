namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // List<Color> color = new List<Color>();
        //int indx = 0; 
        List<List<Button>> buttons = new List<List<Button>>();
        public Form1()
        {
            InitializeComponent();
            CreateBtns();

            Width = 500;
            Height = 350;

            //this.Cursor = Cursors.Hand;

            //color.Add(Color.Yellow);
            //color.Add(Color.Green);
            //color.Add(Color.Yellow);
            //color.Add(Color.Red);
        }

        
        private void CreateBtns()
        {
            int posH1 = 0;
            int posH2 = 0;
            int posH3 = 0;

            for (int i = 0; i < 3; i++)
            { 
                buttons.Add( new List<Button>());
            
                for (int j = 0; j < 3;j++)
                {
                    buttons[i].Add(new Button());                                       
                    buttons[i][j].Text = $"Выбери меня)";
                    buttons[i][j].BackColor = Color.Black;
                    buttons[i][j].ForeColor = Color.Wheat;
                    buttons[i][j].Width = 100;
                    buttons[i][j].Height = 100;
                    if (i == 0)
                    {
                        posH1 += buttons[i][j].Width + 5;
                        buttons[i][j].Location = new Point(posH1, 0);
                    }
                        
                    if (i == 1)
                    {
                        posH2 += buttons[i][j].Width + 5;
                        buttons[i][j].Location = new Point(posH2, 100);
                    }
                        
                    if (i == 2)
                    {
                        posH3 += buttons[i][j].Width + 5;
                        buttons[i][j].Location = new Point(posH3, 200);
                    }
                        

                    buttons[i][j].Click += btn_click;
                    
                }

            }

            for (int i =0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    this.Controls.Add(buttons[i][j]);
            }        
            
            
        }

        int choice = 0;
        private void btn_click(object? sender, EventArgs e)
        {
            Button tmp = sender as Button;
            tmp.BackColor = Color.Green;
            


            
            if (choice % 2 == 0 && tmp.Text == "Выбери меня)")
            {
                tmp.Text = "X";
                tmp.BackColor = Color.Yellow;
                tmp.ForeColor = Color.Black;
                choice++;
            }
            else if (choice % 2 == 1 && tmp.Text == "Выбери меня)")
            {
                tmp.Text = "O";
                tmp.BackColor = Color.Green;
                tmp.ForeColor = Color.Black;
                choice++;
            }

            if (buttons[0][0].Text == "X" && buttons[1][0].Text == "X" && buttons[2][0].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();                
            }
            if (buttons[2][0].Text == "X" && buttons[2][1].Text == "X" && buttons[2][2].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][2].Text == "X" && buttons[1][2].Text == "X" && buttons[2][2].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][0].Text == "X" && buttons[0][1].Text == "X" && buttons[0][2].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][0].Text == "X" && buttons[1][1].Text == "X" && buttons[2][2].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][2].Text == "X" && buttons[1][1].Text == "X" && buttons[2][0].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[1][0].Text == "X" && buttons[1][1].Text == "X" && buttons[1][2].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][1].Text == "X" && buttons[1][1].Text == "X" && buttons[2][1].Text == "X")
            {
            DialogResult res = MessageBox.Show("X - win", "X - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }


            if (buttons[0][0].Text == "O" && buttons[1][0].Text == "O" && buttons[2][0].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[2][0].Text == "O" && buttons[2][1].Text == "O" && buttons[2][2].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][2].Text == "O" && buttons[1][2].Text == "O" && buttons[2][2].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][0].Text == "O" && buttons[0][1].Text == "O" && buttons[0][2].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][0].Text == "O" && buttons[1][1].Text == "O" && buttons[2][2].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][2].Text == "O" && buttons[1][1].Text == "O" && buttons[2][0].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[1][0].Text == "O" && buttons[1][1].Text == "O" && buttons[1][2].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();
            }
            if (buttons[0][1].Text == "O" && buttons[1][1].Text == "O" && buttons[2][1].Text == "O")
            {
            DialogResult res = MessageBox.Show("0 - win", "0 - win", MessageBoxButtons.OK);
            if (res == DialogResult.OK) this.Close();

            }
            
            
        }





        //private void CreateBtns(int count = 3)
        //{
        //    int posH = 0;

        //    for (int i = 0; i < count; i++)
        //    {
        //        if (i == 0)
        //        {
        //            this.Controls.Add(new Button()
        //            {
        //                Text = $"Btn {i.ToString()}",
        //                BackColor = Color.Black,
        //                ForeColor = Color.Wheat,
        //                Location = new Point(posH += 80, 0)

        //            });
        //            this.Controls[this.Controls.Count - 1].Click += (sender, e) => (sender as Button).BackColor = Color.Green;
        //        }
        //        else if (i == 1)
        //        {
        //            this.Controls.Add(new Button()
        //            {
        //                Text = $"Btn {i.ToString()}",
        //                BackColor = Color.Black,
        //                ForeColor = Color.Wheat,
        //                Location = new Point(posH += 80, posH += 80)
        //            });
        //            this.Controls[this.Controls.Count - 1].Click += (sender, e) => (sender as Button).BackColor = Color.Green;
        //        }
        //        else if (i == 2)
        //        {
        //            this.Controls.Add(new Button()
        //            {
        //                Text = $"Btn {i.ToString()}",
        //                BackColor = Color.Black,
        //                ForeColor = Color.Wheat,
        //                Location = new Point(posH += 80, posH += 160)
        //            });
        //            this.Controls[this.Controls.Count - 1].Click += (sender, e) => (sender as Button).BackColor = Color.Green;
        //        }


        //        for (int j = 0; j < count; j++)
        //        {




        //        }

        //    }
        //}




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //this.BackColor = Color.Red;
        //    //this.Size = new Size(250, 250);
        //    //this.Size = new Size(this.Size.Width + 10, 250);
        //    //this.WindowState = FormWindowState.Minimized;
        //    //this.WindowState = FormWindowState.Maximized;
        //    //this.Cursor = Cursors.WaitCursor;
        //    //this.Cursor = Cursors.Arrow;
        //    //this.Text = "simple text";


        //    //indx++;
        //    //if (indx % 4 == 1) { this.BackColor = Color.Yellow; }            
        //    //else if (indx % 4 == 2) {  this.BackColor = Color.Green; }
        //    //else if (indx % 4 == 3) {  this.BackColor = Color.Yellow;  }
        //    //else if (indx %4 == 0 ) { this.BackColor = Color.Red; }

        //    //this.BackColor = color[++indx % color.Count];

        //    //this.Size = new Size(50, 50);




        //}
    }
}