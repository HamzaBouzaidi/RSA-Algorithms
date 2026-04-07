using System;
using System.Windows.Forms;

namespace RSA_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtStatus.Text = "RSA project UI scaffold is ready.";
            txtExplanation.Text = "The RSA implementation steps will be added in the next commit.";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Parameter calculation is not implemented yet.";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Encryption is not implemented yet.";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Save is not implemented yet.";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Read is not implemented yet.";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Decryption is not implemented yet.";
        }
    }
}
