using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alphaVote.Views
{
    public partial class FrmRegister : Form
    {
        private FrmLogin frmLogin;
        public FrmRegister(FrmLogin loginForm)
        {
            InitializeComponent();
            frmLogin = loginForm;
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //linkRegister();
            frmLogin.Show();
            this.Close();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin.Show();
            this.Close();
        }
    }
}
