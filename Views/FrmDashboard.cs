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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            SnackMsg.Show(this, "Welcome to AlphaVote", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            BtnExit.BackgroundColor = Color.FromArgb(196, 43, 28);
            
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void BtnMinimize_MouseHover(object sender, EventArgs e)
        {
            BtnMinimize.BackgroundColor = Color.FromArgb(23, 29, 33);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PageComponent.SetPage(0);
        }

        private void BtnEvents_Click(object sender, EventArgs e)
        {
            PageComponent.SetPage(1);
        }

        private void BtnCandidates_Click(object sender, EventArgs e)
        {
            PageComponent.SetPage(2);
        }

        private void BtnVoters_Click(object sender, EventArgs e)
        {
            PageComponent.SetPage(3);
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
            PageComponent.SetPage(4);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PageComponent.SetPage(5);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //logout
        }

   
    }
}
