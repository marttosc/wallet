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
    public partial class WalletPanel : Form
    {
        private Form LoginForm = null;
        private User LoggedUser = null;

        private static DAOFlag Flag = new DAOFlag();
        private static DAOCard Card = new DAOCard();

        private WalletPanel()
        {
            InitializeComponent();
        }

        public WalletPanel(Form LoginForm, User LoggedUser) : this()
        {
            this.LoginForm = LoginForm;
            this.LoggedUser = LoggedUser;
        }

        private Login GetLoginForm()
        {
            return (Login)LoginForm;
        }

        private User GetUser()
        {
            return LoggedUser;
        }

        private void LoadCards()
        {
            dgvSearch.DataSource = WalletPanel.Card.ListCardsByUser(GetUser());
        }

        private void FilterCards(String column, String value)
        {
            dgvSearch.DataSource = WalletPanel.Card.FilterCardsByUser(GetUser(), column, value);
        }

        private List<Flag> LoadFlags()
        {
            return WalletPanel.Flag.ListFlags();
        }

        private void WalletPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetLoginForm().Close();
        }

        private void WalletPanel_Load(object sender, EventArgs e)
        {
            // Set the window title.
            this.Text = GetUser().Name + " - Wallet!";

            // Set the TextBox Owner's from Add Pane.
            txtOwner.Text = GetUser().Name;

            // Load cards.
            LoadCards();

            // Load flags.
            cbbAddFlag.DataSource = LoadFlags();
            cbbAddFlag.DisplayMember = "Name";
            cbbAddFlag.ValueMember = "Id";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvSearch.Enabled = false;

            LoadCards();

            dgvSearch.Enabled = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var column = "Number";

            if (rdbFilter_Id.Checked)
            {
                column = "Id";
            }

            if (txtFilter.Text.Trim().Equals(""))
            {
                LoadCards();
            }
            else
            {
                FilterCards(column, txtFilter.Text.Trim());
            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            if (ValidateAddForm())
            {
                MaskFormat limit = txtAddLimit.TextMaskFormat;
                txtAddLimit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                Card card = new Card();

                card.Owner = GetUser();
                card.Flag = (Flag)cbbAddFlag.SelectedItem;
                card.Number = txtAddNumber.Text.Trim();
                card.ExpireMonth = Convert.ToInt32(cbbAddExpireMonth.SelectedItem);
                card.ExpireYear = Convert.ToInt32(cbbAddExpireYear.SelectedItem);
                card.Cvc = txtAddCvc.Text.Trim();
                card.Limit = Convert.ToDouble(txtAddLimit.Text.Trim());

                if (WalletPanel.Card.Save(card))
                {
                    MessageBox.Show("Cartão salvo com sucesso!");

                    LoadCards();

                    ClearAddForm();

                    tabPanel.SelectTab(tabContentSearch);
                }
                else
                {
                    MessageBox.Show("Erro ao salvar o cartão.");
                }

                txtAddLimit.TextMaskFormat = limit;
            }
        }

        private bool ValidateAddForm()
        {
            if (cbbAddFlag.SelectedValue == null)
            {
                MessageBox.Show("Informe a bandeira do cartão.");

                cbbAddFlag.Focus();

                return false;
            }

            MaskFormat number = txtAddNumber.TextMaskFormat;
            MaskFormat cvc = txtAddCvc.TextMaskFormat;
            MaskFormat limit = txtAddLimit.TextMaskFormat;

            txtAddNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtAddCvc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtAddLimit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtAddNumber.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe o número do cartão.");

                txtAddNumber.Focus();

                return false;
            }

            if (txtAddCvc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe o CVC do cartão.");

                txtAddCvc.Focus();

                return false;
            }

            if (cbbAddExpireMonth.SelectedItem == null)
            {
                MessageBox.Show("Selecione o mês de validade.");

                cbbAddExpireMonth.Focus();

                return false;
            }

            if (cbbAddExpireYear.SelectedItem == null)
            {
                MessageBox.Show("Selecione o ano de validade.");

                cbbAddExpireYear.Focus();

                return false;
            }

            if (txtAddLimit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe o limite do cartão.");

                txtAddLimit.Focus();

                return false;
            }

            txtAddNumber.TextMaskFormat = number;
            txtAddCvc.TextMaskFormat = cvc;
            txtAddLimit.TextMaskFormat = limit;

            return true;
        }

        private void ClearAddForm()
        {
            cbbAddFlag.SelectedIndex = -1;
            txtAddNumber.Text = String.Empty;
            txtAddCvc.Text = String.Empty;
            cbbAddExpireMonth.SelectedIndex = -1;
            cbbAddExpireYear.SelectedIndex = -1;
            txtAddLimit.Text = String.Empty;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ClearAddForm();
        }
    }
}
