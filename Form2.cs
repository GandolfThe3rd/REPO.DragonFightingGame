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

        public static frmFight instance;

        public frmFight()
        {
            InitializeComponent();

            instance = this;
            btnRest.Hide();
        }
    }
}
