using Domain;
using Domain.Models;
using Infra;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;

            String Cpf = txtCpf.Text.Trim();
            String Password = txtPassword.Text;

            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!User.ValidateCpf(txtCpf.Text.Trim()))
            {
                MessageBox.Show("CPF inválido!");

                txtCpf.Focus();
            }
            else
            {
                User user = null;

                DAOUser dao = new DAOUser();

                user = dao.DoLogin(Cpf, Password);

                if (user is User)
                {
                    WalletPanel panel = new WalletPanel(this, user);

                    panel.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("CPF ou senha inválidos.");
                }
            }

            btnEntrar.Enabled = true;
        }

        private void lnkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterViaLogin register = new RegisterViaLogin(this);

            register.Show();

            this.Visible = false;
        }

        public void SetCpf(String cpf)
        {
            txtCpf.Text = cpf;
        }
    }
}
