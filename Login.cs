using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "Matteo" || txt_user.Text == "matteo" || txt_user.Text == "admin" || txt_user.Text == "Admin" && txt_pwd.Text == "root" || txt_pwd.Text == "")
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR! | User and/or PWD incorrect!");
                txt_pwd.Text = "";
                txt_user.Text = "";
            }
                
                

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFO! | PROGRAM CREATED BY: SABAUDO LLC! - MIT LICENCE GITHUB");
        }
    }
}
