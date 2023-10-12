using BusinessObject;
using DataAccess.Repository;
using DataValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartoonManagementWinApp_DoHoangAnh
{
    public partial class frmCartoonDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public ICartoonRepository cartoonRepository { get; set; }
        public Cartoon cartoonInfo { get; set; }

        public frmCartoonDetails()
        {
            InitializeComponent();
        }
        private void frmCartoonDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate) // Insert
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;

            } else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtCartoonID.Enabled = false;

                txtCartoonID.Text = cartoonInfo.CartoonID.ToString() ;
                txtCartoonName.Text = cartoonInfo.CartoonName;
                txtEmail.Text = cartoonInfo.Email;
                txtPassword.Text = cartoonInfo.Password;
                txtConfirm.Text = cartoonInfo.Password;
                txtCity.Text = cartoonInfo.qwewqewq;
                txtCountry.Text = cartoonInfo.Country;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }

                Cartoon cartoon = new Cartoon
                {
                    CartoonID = cartoonInfo.CartoonID,
                    CartoonName = txtCartoonName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    qwewqewq = txtCity.Text,
                    Country = txtCountry.Text
                };
                cartoonRepository.UpdateCartoon(cartoon);
                MessageBox.Show("Update successfully!!", "Update cartoon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCartoonName.Text = cartoon.CartoonName;
                txtEmail.Text = cartoon.Email;
                txtPassword.Text = cartoon.Password;
                txtConfirm.Text = cartoon.Password;
                txtCity.Text = cartoon.qwewqewq;
                txtCountry.Text = cartoon.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update cartoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong Email!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm does not match with Password!!!");
                }

                Cartoon cartoon = new Cartoon
                {
                    CartoonID = int.Parse(txtCartoonID.Text),
                    CartoonName = txtCartoonName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    qwewqewq = txtCity.Text,
                    Country = txtCountry.Text
                };
                cartoonRepository.AddCartoon(cartoon);
                MessageBox.Show("Add successfully!!", "Add new cartoon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new cartoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
