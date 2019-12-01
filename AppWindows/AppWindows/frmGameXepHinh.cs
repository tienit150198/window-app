using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows
{
    public partial class frmGameXepHinh : Form
    {
        Color colorEnter = Color.Violet;
        Color colorLeave = Color.Coral;
        int originX = 300 / 50;
        int originY = 250 / 50;
        int locationX = 0;
        int locationY = 0;
        List<Button> listButton;
        int time = 0;
        public frmGameXepHinh()
        {
            InitializeComponent();
            genericList();

        }

        private void genericList()
        {
            listButton = new List<Button>();
            listButton.Add(btnOne);
            listButton.Add(btnTwo);
            listButton.Add(btnThree);
            listButton.Add(btnFour);
            listButton.Add(btnFive);
            listButton.Add(btnSix);
            listButton.Add(btnSeven);
            listButton.Add(btnEight);
        }


        public bool checkWin()
        {
            if (equalsLocationY(btnOne, btnTwo, btnThree) && equalsLocationY(btnFour, btnFive, btnSix) && equalsLocationY(btnSeven, btnEight, btnZero) &&
                equalsLocationX(btnOne, btnTwo, btnThree) && equalsLocationX(btnFour, btnFive, btnSix) && equalsLocationX(btnSeven, btnEight, btnZero) &&
                equalsLocationY_2(btnOne, btnFour, btnSeven) && equalsLocationY_2(btnTwo, btnFive, btnEight) && equalsLocationY_2(btnTwo, btnSix, btnZero))
                return true;

            return false;
        }

        public bool equalsLocationY_2(Button x, Button y, Button z)
        {
            return ((y.Location.Y - x.Location.Y == 100) && (z.Location.Y - y.Location.Y == 100));
        }

        public bool equalsLocationY(Button x, Button y, Button z)
        {
            return ((x.Location.Y == y.Location.Y) && (z.Location.Y == x.Location.Y));
        }

        public bool equalsLocationX(Button x, Button y, Button z)
        {
            return ((y.Location.X - x.Location.X) == 100 && (z.Location.X - y.Location.X) == 100);
        }

        private void frmGameXepHinh_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnThree_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            getLocation(btnTwo);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnTwo, btnZero);

            }
        }

        private void btnThree_MouseEnter(object sender, EventArgs e)
        {
            locationX = btnTwo.Location.X / 50;
            locationY = btnTwo.Location.Y / 50;

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnThree, btnZero);
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            getLocation(btnSix);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnSix, btnZero);
            }

        }

        private void swapButton(Button btnSwap, Button btnZero)
        {
            Button tmp = new Button();
            tmp.Location = btnSwap.Location;
            btnSwap.Location = btnZero.Location;
            btnZero.Location = tmp.Location;

            if (checkWin())
            {
                MessageBox.Show("You Win - time in round - " + lbTime.Text, "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = false;
                time = 0;
            }
        }

        private void getLocation(Button btnX)
        {
            locationX = btnX.Location.X / 50;
            locationY = btnX.Location.Y / 50;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            getLocation(btnOne);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnOne, btnZero);
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            getLocation(btnThree);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnThree, btnZero);
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            getLocation(btnEight);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnEight, btnZero);
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            getLocation(btnFour);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnFour, btnZero);
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            getLocation(btnSeven);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnSeven, btnZero);
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            getLocation(btnFive);

            if (Math.Abs(locationX - originX) <= 2 && Math.Abs(locationY - originY) <= 0 || Math.Abs(locationX - originX) <= 0 && Math.Abs(locationY - originY) <= 2)
            {
                swapButton(btnFive, btnZero);
            }
        }



        private void initializeGame()
        {
            Random rd = new Random();
            int init = rd.Next(40) + 10;

            lbTime.Text = "0 : 0 : 0";

            for (int i = 0; i < init; i++)
            {
                int index = rd.Next(listButton.Count), indexNext = rd.Next(listButton.Count);
                while (index == indexNext)
                {
                    index = rd.Next(listButton.Count);
                    indexNext = rd.Next(listButton.Count);
                }

                swapButton(listButton[index], listButton[indexNext]);
            }
        }

        private void btnZero_LocationChanged(object sender, EventArgs e)
        {
            // update location origin
            originX = locationX;
            originY = locationY;

            if(time == 0)
            {
                timer1.Enabled = true;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            initializeGame();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = colorEnter;
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = colorLeave;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            int hour = 0, minute = 0, second = 0;

            hour = time / 3600;
            time %= 3600;
            minute = time / 60;
            time %= 60;
            second = time;

            lbTime.Text = hour + " : " + minute + " : " + second;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeGame();
            time = 0;
            timer1.Enabled = false;
        }
    }
}
