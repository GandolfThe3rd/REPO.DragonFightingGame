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
        int playerInitiative = 0; // declorations
        string[] p1Names;
        string[] p2Names;
        int[] p1values;
        int[] p2values;

        bool p1Block;
        bool p2Block;
        bool p1MustRest;
        bool p2MustRest;

        bool nextRound = false;

        int damage;

        public static frmFight instance;

        public frmFight()
        {
            InitializeComponent();

            onLoad();
        }

        int randomRoll() // dice roll
        {
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);
            return dice;

        }

        void takeInitiative() // rolls for the next turn
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

        void onLoad() // Hides rest button and transfers player data from the pervious form
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

        void userInterface() //updates ui
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
        void block () // enable block and adds message to battle log
        {
            switch (playerInitiative)
            {
                case 1:
                    p1Block = true;
                    message($"{p1Names[0]}'s Turn:" +
                        $"\n{p1Names[1]} performs a Block!");
                    return;
                case 2:
                    p2Block = true;
                    message($"{p2Names[0]}'s Turn:" +
                        $"\n{p2Names[1]} performs a Block!");
                    return;
            }

        }

        void attack() // attack calculations. check for block and prevents adding of health glitch, and adds message to battle log
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

                    message($"{p1Names[0]}'s Turn:" +
                        $"\n{p1Names[1]} performs an Attack!");

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

                    message($"{p2Names[0]}'s Turn:" +
                        $"\n{p2Names[1]} performs an Attack!");

                    return;
            }

        }

        void specialAttack() // special attack, compleated cooldown mechanic, and adds message to battle log
        {
            switch (playerInitiative)
            {
                case 1:

                    if (p2Block == true && p2values[3] >= p1values[2])
                    {
                        
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

                    message($"{p1Names[0]}'s Turn:" +
                        $"\n{p1Names[1]} performs a Special Attack!");
                    p1MustRest = true;

                    return;
                case 2:

                    if (p1Block == true && p1values[3] >= p2values[2])
                    {
                        
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

                    message($"{p2Names[0]}'s Turn:" +
                        $"\n{p2Names[1]} performs a Special Attack!");

                    p2MustRest = true;

                    return;
            }

        }

        void turns() // checks if it switches to the next player, or roll the dice
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

        void rest(int restingDragon) // Checks which dragon is resting and forces that dragon to rest
        {
            switch(restingDragon)
            {
                case 1:
                    {
                        btnRest.Show();
                        message($"{p1Names[0]}'s Turn" +
                            $"\n{p1Names[1]} is too tired, and rests");

                        p1MustRest = false;

                        break;
                    }
                case 2:
                    {
                        btnRest.Show();
                        message($"{p2Names[0]}'s Turn" +
                            $"\n{p2Names[1]} is too tired, and rests");

                        p2MustRest = false;

                        break;
                    }
            }
        }

        void checkForRest() // checks if a dragon has performed special attack, and if it's that dragons tuen so that it can force it to rest
        {
            if (playerInitiative == 1 && p1MustRest == true)
            {
                rest(1);
            }
            else if (playerInitiative == 2 && p2MustRest == true)
            {
                rest(2);
            }
        }

        void message(string message) // easily write messages and scrolls down the Battle Log
        {
            rtbBattleLog.Text += "\n------------------------------" +
                "\n" + message +
                "\n------------------------------";
            rtbBattleLog.SelectionStart = rtbBattleLog.Text.Length;
            rtbBattleLog.ScrollToCaret();
        }

        void dead()
        {
            if (p1values[0] <= 0)
            {
                message($"{p1Names[0]}'s Dragon {p1Names[1]} has died" +
                    $"\n {p2Names[0]} is the winner!");

                btnAttack.Enabled = false;
                btnBlock.Enabled = false;
                btnSpecial.Enabled = false;
                btnRest.Enabled = false;
            }
            else if (p2values[0] <= 0)
            {
                message($"{p2Names[0]}'s Dragon {p2Names[1]} has died" +
                    $"\n {p1Names[0]} is the winner!");

                btnAttack.Enabled = false;
                btnBlock.Enabled = false;
                btnSpecial.Enabled = false;
                btnRest.Enabled = false;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e) // assigning buttons, and all checks performed here
        {
            attack();
            turns();
            checkForRest();
            dead();
            userInterface();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            specialAttack();
            turns();
            checkForRest();
            dead();
            userInterface();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            block();
            turns();
            checkForRest();
            dead();
            userInterface();
        }

        private void btnRest_Click(object sender, EventArgs e) // turn hides rest button
        {
            btnRest.Hide();
            turns();
            userInterface();
        }
    }
}
