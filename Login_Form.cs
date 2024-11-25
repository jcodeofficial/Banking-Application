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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            if (usrtxt.Text!=string.Empty || passtxt.Text!=string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if (user1 != null) 
               
                    if (user1.Password.Equals(passtxt.Text)) 
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
               
                    }
                    else 
                    {
                        MessageBox.Show("password incorrect");
                    }
            }
            else
            {
                MessageBox.Show("please eusername and password");
            }


        }
    }
}
