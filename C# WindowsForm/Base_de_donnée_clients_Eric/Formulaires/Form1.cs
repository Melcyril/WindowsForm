using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaires
{
    public partial class Form1 : Form
    {
        InterfaceVPC InterfaceVPC = new InterfaceVPC();
        public Form1()
        {
            InitializeComponent();
            TXTB_EMAIL.Text = "toto@toto.com";
            TXTB_MDP.Text = "123";
        }

        private void BT_CONNEXION_Click(object sender, EventArgs e)
        {
            if(TXTB_EMAIL.ForeColor!=Color.Red && TXTB_MDP.Text.Length > 1)
            {
                InterfaceVPC.Show();
                this.Hide();
            }
            else
            {
                LB_WARNING.Text = "Vérifier vos identifiants.";
            }
        }

        private void BT_FERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
