using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_Fighting_Game
{
    public partial class frmFight : Form
    {
        int playerInitiative = 0;
        string[] p1Names;
        string[] p2Names;
        int[] p1values;
        int[] p2values;

        bool p1Block;
        bool p2Block;

        bool nextRound = false;

        int damage;

        public static frmFight instance;

        public frmFight()
        {
            InitializeComponent();

            onLoad();
        }

        int randomRoll()
        {
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);
            return dice;

        }

        void takeInitiative()
        {
            int playerTurn = 0;
            int player1Roll = 0;
            int player2Roll = 0;

            do
            {
                player1Roll = randomRoll();
                player2Roll = randomRoll();
            }
            while (player1Roll == player2Roll);

            if (player1Roll > player2Roll)
            {
                playerTurn = 1;
            }
            else
            {
                playerTurn = 2;
            }

            playerInitiative = playerTurn;
        }

        void onLoad()
        {
            instance = this;
            btnRest.Hide();

            p1Names = FrmCharacterCreationWindow.instance.p1Data;
            p2Names = FrmCharacterCreationWindow.instance.p2Data;
            p1values = FrmCharacterCreationWindow.instance.p1Values;
            p2values = FrmCharacterCreationWindow.instance.p2Values;

            takeInitiative ();
            userInterface();
            nextRound = false;
        }

        void userInterface()
        {
            switch (playerInitiative)
            {
                case 1:
                    grpChar1.Text = $"{p1Names[1]} the {p1Names[2]}'s turn";
                    lblHp1.Text = $"HP: {p1values[0]}";
                    this.Text = p1Names[0];

                    grpOpponent.Text = $"Opponent: {p2Names[0]}";
                    lblSecondPlayer.Text = $"{p2Names[1]} the {p2Names[2]}'s turn";
                    lblHp2.Text = $"HP: {p2values[0]}";

                    return;
                case 2:
                    grpChar1.Text = $"{p2Names[1]} the {p2Names[2]}'s turn";
                    lblHp1.Text = $"HP: {p2values[0]}";
                    this.Text = p2Names[0];

                    grpOpponent.Text = $"Opponent: {p1Names[0]}";
                    lblSecondPlayer.Text = $"{p1Names[1]} the {p1Names[2]}'s turn";
                    lblHp2.Text = $"HP: {p1values[0]}";
                    return;
            }
        }
        void block ()
        {
            switch (playerInitiative)
            {
                case 1:
                    p1Block = true;
                    return;
                case 2:
                    p2Block = true;
                    return;
            }

        }

        void attack()
        {
            switch(playerInitiative)
            {
                case 1:

                    if (p2Block == true && p2values[3] >= p1values[1])
                    {
                        return;
                    }
                    else if (p2Block == true)
                    {
                        damage = p1values[1];
                        p2values[0] = p2values[0] + p2values[3] - damage;
                    }
                    else
                    {
                        p2values[0] = p2values[0] - p1values[1];
                    }

                    return;
                case 2:

                    if (p1Block == true && p1values[3] >= p2values[1])
                    {
                        return;
                    }
                    else if (p1Block == true)
                    {
                        damage = p2values[1];
                        p1values[0] = p1values[0] + p1values[3] - damage;
                    }
                    else
                    {
                        p1values[0] = p1values[0] - p2values[1];
                    }

                    return;
            }

        }

        void specialAttack()
        {
            switch (playerInitiative)
            {
                case 1:

                    if (p2Block == true && p2values[3] >= p1values[2])
                    {
                        return;
                    }
                    else if (p2Block == true)
                    {
                        damage = p1values[2];
                        p2values[0] = p2values[0] + p2values[3] - damage;
                    }
                    else
                    {
                        p2values[0] = p2values[0] - p1values[2];
                    }

                    return;
                case 2:

                    if (p1Block == true && p1values[3] >= p2values[2])
                    {
                        return;
                    }
                    else if (p1Block == true)
                    {
                        damage = p2values[2];
                        p1values[0] = p1values[0] + p1values[3] - damage;
                    }
                    else
                    {
                        p1values[0] = p1values[0] - p2values[2];
                    }

                    return;
            }

        }

        void turns()
        {
            if (nextRound == false)
            {
                switch (playerInitiative)
                {

                    case 1:
                        playerInitiative = 2;
                        nextRound = true;
                        return;
                    case 2:
                        playerInitiative = 1;
                        nextRound = true;
                        return;
                }
            }
            else
            {
                takeInitiative();
                    p1Block = false;
                    p2Block = false;
                    nextRound = false;
                    return;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            attack();
            turns();
            userInterface();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            specialAttack();
            turns();
            userInterface();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            block();
            turns();
            userInterface();
        }
    }
}
