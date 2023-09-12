using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SeaFightEVT70
{
    public partial class Form1 : Form
    {
        GameLogic gl = new GameLogic();

        static int maxShipAmount = 6;
        int shipsL = maxShipAmount;
        int shipsR = maxShipAmount;
        int state = 0;
        int fnumber = 0;

        public Form1()
        {
            InitializeComponent();
            groupBox2.Hide();
            groupBox1.Hide();
            state = 0;

        }

        private void buttonSTR_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            fnumber = 2;
            groupBox1.Hide();

 
        }

        private void ButtonClick(int cell)
        {
            switch (state)
            {
                case 0:
                    SetCell(fnumber, cell, 0);
                    switch (fnumber)
                    {
                        case 1:
                            shipsL--;
                            break;
                        case 2:
                            shipsR--;
                            break;
                    }
                    if(shipsR ==0)
                    {
                        groupBox2.Hide();
                        groupBox1.Show();
                        fnumber = 1;
                    }
                    else if(shipsL==0)
                    {
                        state = 2;
                    }
                    break;
                case 1:
                    SetCell(fnumber, cell, 1);
                    break;
            }

        }

        private void SetCell(int f, int cell, int state)
        {
            switch(state)
            {
                case 0:
                    gl.SetShip(f, cell);
                    break;

                case 1:
                    gl.Shoot(f, cell);
                    break;
            }

        }


        

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}