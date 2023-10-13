using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartoonManagementWinApp_DOHOANGANH
{
    public partial class frmLogin : Form
    {
        ICartoonRepository cartoonRepository = new CartoonRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            Cartoon loginCartoon = cartoonRepository.Login(Email, Password);
            if (loginCartoon != null)
            {
                MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string username = loginCartoon.Role;
                frmCartoonManagement frmCartoonManagement = null;

                    frmCartoonManagement = new frmCartoonManagement
                    {
                        loginCartoon = loginCartoon,
                    };
                    frmCartoonManagement.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmCartoonManagement.Show();
            }
            else
            {
                if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
