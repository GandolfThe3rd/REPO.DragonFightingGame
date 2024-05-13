using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_Fighting_Game
{
    public partial class FrmCharacterCreationWindow : Form
    {
        public static FrmCharacterCreationWindow instance;

        public string[] p1Data = new string[3];
        public string[] p2Data = new string[3];
        public int[] p1Values = new int[4];
        public int[] p2Values = new int[4];

        int dragon1Choice = 0;
        int dragon2Choice = 0;

        const string iceDragonName = "Ice Dragon";
        const int iceDragonHealth = 30;
        const int iceDragonAttack = 4;
        const int iceDragonSpecialAttack = 9;
        const int iceDragonBlock = 5;

        const string fireDragonName = "Fire Dragon";
        const int fireDragonHealth = 20;
        const int fireDragonAttack = 5;
        const int fireDragonSpecialAttack = 12;
        const int fireDragonBlock = 4;

        const string windDragonName = "Wind Dragon";
        const int windDragonHealth = 40;
        const int windDragonAttack = 3;
        const int windDragonSpecialAttack = 7;
        const int windDragonBlock = 5;

        const string earthDragonName = "Earth Dragon";
        const int earthDragonHealth = 50;
        const int earthDragonAttack = 2;
        const int earthDragonSpecialAttack = 5;
        const int earthDragonBlock = 6;

        bool player1Ready;
        bool player2Ready;

        public FrmCharacterCreationWindow()
        {
            InitializeComponent();

            instance = this;

        }

        private void btnPlayer1Save_Click(object sender, EventArgs e)
        {
            if (txtPlayer1Name.Text != "" && txtDragon1Name.Text != "" && dragon1Choice != 0)
            {
                int button1Press = 0;
                saveValues(button1Press);
                btnPlayer1Save.Enabled = false;
                player1Ready = true;
            }
            checkStartButton();
            
        }

        private void btnPlayer2Save_Click(object sender, EventArgs e)
        {
            if (txtPlayer2Name.Text != "" && txtDragon2Name.Text != "" && dragon2Choice != 0)
            {
                int button2Press = 1;
                saveValues(button2Press);
                btnPlayer2Save.Enabled = false;
                player2Ready = true;
            }
            checkStartButton();
        }

        void saveValues(int buttonPress)
        {
            switch (buttonPress)
            {
                case 0:
                        p1Data[0] = txtPlayer1Name.Text;
                        p1Data[1] = txtDragon1Name.Text;

                        switch (dragon1Choice)
                        {
                            case 1:
                                p1Values[0] = fireDragonHealth;
                                p1Values[1] = fireDragonAttack;
                                p1Values[2] = fireDragonSpecialAttack;
                                p1Values[3] = fireDragonBlock;
                                p1Data[2] = fireDragonName;
                                return;
                            case 2:
                                p1Values[0] = iceDragonHealth;
                                p1Values[1] = iceDragonAttack;
                                p1Values[2] = iceDragonSpecialAttack;
                                p1Values[3] = iceDragonBlock;
                                p1Data[2] = iceDragonName;
                                return;
                            case 3:
                                p1Values[0] = windDragonHealth;
                                p1Values[1] = windDragonAttack;
                                p1Values[2] = windDragonSpecialAttack;
                                p1Values[3] = windDragonBlock;
                                p1Data[2] = windDragonName;
                                return;
                            case 4:
                                p1Values[0] = earthDragonHealth;
                                p1Values[1] = earthDragonAttack;
                                p1Values[2] = earthDragonSpecialAttack;
                                p1Values[3] = earthDragonBlock;
                                p1Data[2] = earthDragonName;
                                return;
                        }
                    return;
                case 1:
                        p2Data[0] = txtPlayer2Name.Text;
                        p2Data[1] = txtDragon2Name.Text;

                        switch (dragon2Choice)
                        {
                            case 1:
                                p2Values[0] = fireDragonHealth;
                                p2Values[1] = fireDragonAttack;
                                p2Values[2] = fireDragonSpecialAttack;
                                p2Values[3] = fireDragonBlock;
                                p2Data[2] = fireDragonName;
                                return;
                            case 2:
                                p2Values[0] = iceDragonHealth;
                                p2Values[1] = iceDragonAttack;
                                p2Values[2] = iceDragonSpecialAttack;
                                p2Values[3] = iceDragonBlock;
                                p2Data[2] = iceDragonName;
                                return;
                            case 3:
                                p2Values[0] = windDragonHealth;
                                p2Values[1] = windDragonAttack;
                                p2Values[2] = windDragonSpecialAttack;
                                p2Values[3] = windDragonBlock;
                                p2Data[2] = windDragonName;
                                return;
                            case 4:
                                p2Values[0] = earthDragonHealth;
                                p2Values[1] = earthDragonAttack;
                                p2Values[2] = earthDragonSpecialAttack;
                                p2Values[3] = earthDragonBlock;
                                p2Data[2] = earthDragonName;
                                return;
                        }
                    return;
            }
            
        }

        void checkStartButton()
        {
            if (player1Ready && player2Ready)
            {
                btnStart.Enabled = true;
            }
        }

        private void radDragon1Fire_CheckedChanged(object sender, EventArgs e)
        {
            dragon1Choice = 1;
        }

        private void radDragon1Ice_CheckedChanged(object sender, EventArgs e)
        {
            dragon1Choice = 2;
        }

        private void radDragon1Wind_CheckedChanged(object sender, EventArgs e)
        {
            dragon1Choice = 3;
        }

        private void radDragon1Earth_CheckedChanged(object sender, EventArgs e)
        {
            dragon1Choice = 4;
        }

        private void radDragon2Fire_CheckedChanged(object sender, EventArgs e)
        {
            dragon2Choice = 1;
        }

        private void radDragon2Ice_CheckedChanged(object sender, EventArgs e)
        {
            dragon2Choice = 2;
        }

        private void radDragon2Wind_CheckedChanged(object sender, EventArgs e)
        {
            dragon2Choice = 3;
        }

        private void radDragon2Earth_CheckedChanged(object sender, EventArgs e)
        {
            dragon2Choice = 4;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmFight frmFight = new frmFight();
            frmFight.Show();
            this.Hide();
        }
    }
}
