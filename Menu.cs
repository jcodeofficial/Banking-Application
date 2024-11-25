using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication_Tutorial
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accno newaccc = new accno();
            newaccc.MdiParent = this;
            newaccc.Show();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updationForm up = new updationForm();
            up.MdiParent = this;
            up.Show();

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Customers ac = new All_Customers();
            ac.MdiParent = this;
            ac.Show();

        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.MdiParent = this;
            dep.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw wit = new Withdraw();
            wit.MdiParent = this;
            wit.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer tra = new Transfer();
            tra .MdiParent = this;
            tra .Show();
        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDForm fd = new FDForm();
            fd .MdiParent = this;
            fd .Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balance_Sheet sh = new Balance_Sheet();
            sh .MdiParent = this;
            sh .Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_FD vfd = new View_FD();
            vfd .MdiParent = this;
            vfd .Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password();
            cp .MdiParent = this;
            cp .Show();
        } 

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
