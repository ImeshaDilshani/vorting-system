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
            bunifuSnackbar1.Show(this, "Welcome to AlphaVote", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuIconButton1_MouseHover(object sender, EventArgs e)
        {
            BtnExit.BackgroundColor = Color.FromArgb(196, 43, 28);
            
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void bunifuIconButton2_MouseHover(object sender, EventArgs e)
        {
            BtnMinimize.BackgroundColor = Color.FromArgb(23, 29, 33);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(5);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //logout
        }
    }
}
