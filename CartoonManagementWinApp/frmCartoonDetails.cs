using BusinessObject;
using DataAccess.Repository;
using DataValidation;
using System;

using System.Windows.Forms;

namespace CartoonManagementWinApp_DOHOANGANH
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

            }
            else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtCartoonID.Enabled = false;

                txtCartoonID.Text = cartoonInfo.CartoonID.ToString();
                txtCartoonName.Text = cartoonInfo.CartoonName;
                txtShortDescription.Text = cartoonInfo.ShortDescription;
                txtCartoonType.Text = cartoonInfo.CartoonType;
                txtDuration.Text = cartoonInfo.Duration.ToString();
                txtActors.Text = cartoonInfo.Actors;
                txtProducer.Text = cartoonInfo.Producer;
                txtDirector.Text = cartoonInfo.Director;
                txtCountry.Text = cartoonInfo.Country;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cartoon cartoon = new Cartoon
                {
                    CartoonID = cartoonInfo.CartoonID,
                    CartoonName = txtCartoonName.Text,
                    ShortDescription = txtShortDescription.Text,
                    Producer = txtProducer.Text,
                    Country = txtCountry.Text,
                    CartoonType = txtCartoonType.Text,
                    Duration = int.Parse(txtDuration.Text),
                    Actors = txtActors.Text,
                    Director = txtDirector.Text,
                };
                cartoonRepository.UpdateCartoon(cartoon);
                MessageBox.Show("Update successfully!!", "Update cartoon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCartoonName.Text = cartoon.CartoonName;
                txtShortDescription.Text = cartoon.ShortDescription;
                txtProducer.Text = cartoon.Producer;
                txtDirector.Text = cartoon.Director;
                txtCountry.Text = cartoon.Country;
                txtDuration.Text = cartoon.Duration.ToString();
                txtActors.Text = cartoon.Actors;
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
                Cartoon cartoon = new Cartoon
                {
                    CartoonID = int.Parse(txtCartoonID.Text),
                    CartoonName = txtCartoonName.Text,
                    ShortDescription = txtShortDescription.Text,
                    Producer = txtProducer.Text,
                    Country = txtLaunchDate.Text
                };
                cartoonRepository.AddCartoon(cartoon);
                MessageBox.Show("Add successfully!!", "Add new cartoon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new cartoon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtActors_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
