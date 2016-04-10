using Domain.Models;
using Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class RegisterViaLogin : Form
    {
        private Form LoginForm = null;

        private RegisterViaLogin()
        {
            InitializeComponent();
        }

        public RegisterViaLogin(Form LoginForm) : this()
        {
            this.LoginForm = LoginForm;
        }

        private void RegisterViaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoginForm is Login)
            {
                LoginForm.Visible = true;

                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            String Name = txtName.Text.Trim();
            String Cpf = txtCpf.Text.Trim();
            DateTime Birthdate = DateTime.Parse(txtBirthdate.Text.Trim());
            String Email = txtEmail.Text.Trim();
            String Password = txtPassword.Text;
            String Address = txtAddress.Text;

            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!User.ValidateCpf(txtCpf.Text.Trim()))
            {
                MessageBox.Show("CPF inválido.");

                txtCpf.Focus();
            }
            else if (!txtPassword.Text.Equals(txtPasswordConfirm.Text))
            {
                MessageBox.Show("Senhas incompatíveis.");
            }
            else
            {
                DAOUser dao = new DAOUser();

                User user = new User {
                    Name = Name,
                    Cpf = Cpf,
                    Birthdate = Birthdate,
                    Email = Email,
                    Password = Password,
                    Address = Address,
                    Income = 0.00
                };

                if (dao.Save(user))
                {
                    MessageBox.Show("Usuário #" + user.Id + " cadastrado com sucesso!");

                    if (LoginForm is Login)
                    {
                        ((Login)LoginForm).SetCpf(Cpf);

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o usuário.\n\nContate o administrador.");
                }
            }

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
    }
}
