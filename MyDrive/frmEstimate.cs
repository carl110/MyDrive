using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDrive
{
    public partial class frmEstimate : Form
    {
        public frmEstimate()
        {
            InitializeComponent();
            Setup();
        }
        private void Setup()
        {
            this.CenterToScreen();
            this.Text = "Drive Estimates";
            this.WindowState = FormWindowState.Normal;
            lblOutPut.Name = "lblOutput";
            lblOutPut.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            lblOutPut.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.Red;
            grpFoundations.Hide();
            lblLength.Hide();
            txtLength.Hide();
            lblMetresLength.Hide();
            lblWidth.Hide();
            txtWidth.Hide();
            lblMetresWidth.Hide();
            lblGBP.Hide();
            txtGBP.Hide();
            lblEuroBottom.Hide();
            txtEuro.Hide();
            lblOutPut.Hide();
            cmdCalculate.Hide();
            cmdClear.Hide();
        }
        private void ShowSecondView()
        {
            lblTitle.ForeColor = Color.Green;
            grpFoundations.Show();
            rdoStandard.Checked = true;
            lblLength.Show();
            txtLength.Show();
            lblMetresLength.Show();
            lblWidth.Show();
            txtWidth.Show();
            lblMetresWidth.Show();
            lblGBP.Show();
            txtGBP.Show();
            lblEuroBottom.Show();
            txtEuro.Show();
            lblOutPut.Show();
            lblOutPut.Text = "";
            lblOutPut.BackColor = Color.Green;
            cmdCalculate.Show();
            cmdClear.Show();
            lblExcahangeRate.Hide();
            txtExchangeRate.Hide();
            lblEuroTop.Hide();
            lblPrice.Hide();
            txtBrick.Hide();
            txtConcrete.Hide();
            txtTarmac.Hide();
            txtGravel.Hide();
            cmdStart.Hide();
            txtGBP.Text = "1";
            txtEuro.Text = txtExchangeRate.Text;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtLength.TextLength > 0 && txtWidth.TextLength > 0)
            {
                double materials = 0;
                double foundations = 1;
                double measurements = Convert.ToDouble(txtLength.Text) * Convert.ToDouble(txtWidth.Text);
                lblOutPut.BackColor = Color.White;
                lblOutPut.Text = grpMaterials.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Substring(3) + " selected with "
                    + grpFoundations.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name.Substring(3) + " foundation";
                if (rdoExtrDeep.Checked)
                {
                    foundations = 1.25;
                }
                if (rdoBrick.Checked)
                {
                    materials = Convert.ToDouble(txtBrick.Text);
                }
                else if (rdoConcrete.Checked)
                {
                    materials = Convert.ToDouble(txtConcrete.Text);
                }
                else if (rdoTarmac.Checked)
                {
                    materials = Convert.ToDouble(txtTarmac.Text);
                }
                else
                {
                    materials = Convert.ToDouble(txtGravel.Text);
                }
                txtGBP.Text = string.Format(new CultureInfo("en-GB"), "{0:C}", Convert.ToDouble(materials * foundations * measurements), 2);
                txtEuro.Text = string.Format(new CultureInfo("en-IE"), "{0:C}", Math.Round(Convert.ToDouble(materials * foundations * measurements), 2) * Convert.ToDouble(txtExchangeRate.Text), 2);
            }
            else
            {
                MessageBox.Show("Length, Width not entered.\nPlease enter dimensions", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtExchangeRate.TextLength == 0 || txtBrick.TextLength == 0 || txtConcrete.TextLength == 0 || txtTarmac.TextLength == 0 || txtGravel.TextLength == 0)
            {
                MessageBox.Show("Exchange Rate of Prices not entered", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ShowSecondView();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtWidth.Clear();
            lblOutPut.Text = "";
            lblOutPut.BackColor = Color.Green;
            txtGBP.Text = "1";
            txtEuro.Text = txtExchangeRate.Text;
        }
        private void miExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LeaveTxtField(object sender, EventArgs e)
        {
            string doubleString = "";
            //Loop through each character in string
            for (int i = 0; i < (sender as TextBox).Text.Length; i++)
            {
                doubleString += (sender as TextBox).Text[i];
                //If first character accepted is a decimal add a 0 before it
                if (doubleString == ".")
                {
                    doubleString = "0.";
                }
                //Check string is double, romove character if not
                if (!double.TryParse(doubleString, out double _))
                {
                    doubleString = doubleString.Remove(doubleString.Length - 1);
                }
            }
            (sender as TextBox).Text = doubleString;
        }
        private void KeyPressEnterTxtFields(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '£') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar != '.' || (sender as TextBox).Text.IndexOf('.') <= -1)
            {
                return;
            }
            e.Handled = true;
        }
    }
}