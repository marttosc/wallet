using Domain.Models;
using Infra;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class WalletPanel : Form
    {
        private Form LoginForm = null;
        private User LoggedUser = null;

        private static DAOFlag Flag = new DAOFlag();
        private static DAOCard Card = new DAOCard();

        private Card CardInAction = null;

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

            cbbUpdFlag.DataSource = LoadFlags();
            cbbUpdFlag.DisplayMember = "Name";
            cbbUpdFlag.ValueMember = "Id";

            cbbDelFlag.DataSource = LoadFlags();
            cbbDelFlag.DisplayMember = "Name";
            cbbDelFlag.ValueMember = "Id";

            // Disable update and delete tabs.
            TabPageState(tabContentUpdate, false);
            TabPageState(tabContentDelete, false);
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

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ClearAddForm();

            BackToPrincipalTab();
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

                    BackToPrincipalTab();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar o cartão.");
                }

                txtAddLimit.TextMaskFormat = limit;
            }
        }

        private void btnUpdCancel_Click(object sender, EventArgs e)
        {
            OutPrivateTabs();
        }

        private void btnUpdSave_Click(object sender, EventArgs e)
        {
            if (ValidateUpdForm())
            {
                MaskFormat limit = txtUpdLimit.TextMaskFormat;
                txtUpdLimit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                Card card = CardInAction;

                card.Flag = (Flag)cbbUpdFlag.SelectedItem;
                card.ExpireMonth = Convert.ToInt32(cbbUpdExpireMonth.SelectedItem);
                card.ExpireYear = Convert.ToInt32(cbbUpdExpireYear.SelectedItem);
                card.Cvc = txtUpdCvc.Text.Trim();
                card.Limit = Convert.ToDouble(txtUpdLimit.Text.Trim());

                if (WalletPanel.Card.Update(card))
                {
                    MessageBox.Show("Cartão atualizado com sucesso!");

                    LoadCards();

                    ClearUpdForm();

                    BackToPrincipalTab();

                    OutPrivateTabs();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o cartão.");
                }

                txtUpdLimit.TextMaskFormat = limit;
            }
        }

        private void btnDelCancel_Click(object sender, EventArgs e)
        {
            OutPrivateTabs();
        }

        private void btnDelSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirma a exclusão do cartão?", "Deletar Cartão",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (WalletPanel.Card.Delete(CardInAction))
                {
                    MessageBox.Show("Cartão excluído com sucesso!");

                    LoadCards();

                    BackToPrincipalTab();

                    OutPrivateTabs();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o cartão.");
                }
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

        private bool ValidateUpdForm()
        {
            if (cbbUpdFlag.SelectedValue == null)
            {
                MessageBox.Show("Informe a bandeira do cartão.");

                cbbUpdFlag.Focus();

                return false;
            }

            MaskFormat number = txtUpdNumber.TextMaskFormat;
            MaskFormat cvc = txtUpdCvc.TextMaskFormat;
            MaskFormat limit = txtUpdLimit.TextMaskFormat;

            txtUpdNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtUpdCvc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtUpdLimit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtUpdNumber.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe o número do cartão.");

                txtUpdNumber.Focus();

                return false;
            }

            if (txtUpdCvc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe o CVC do cartão.");

                txtUpdCvc.Focus();

                return false;
            }

            if (cbbUpdExpireMonth.SelectedItem == null)
            {
                MessageBox.Show("Selecione o mês de validade.");

                cbbUpdExpireMonth.Focus();

                return false;
            }

            if (cbbUpdExpireYear.SelectedItem == null)
            {
                MessageBox.Show("Selecione o ano de validade.");

                cbbUpdExpireYear.Focus();

                return false;
            }

            if (txtUpdLimit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe o limite do cartão.");

                txtUpdLimit.Focus();

                return false;
            }

            txtUpdNumber.TextMaskFormat = number;
            txtUpdCvc.TextMaskFormat = cvc;
            txtUpdLimit.TextMaskFormat = limit;

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

        private void ClearUpdForm()
        {
            txtUpdId.Text = String.Empty;
            cbbUpdFlag.SelectedIndex = -1;
            txtUpdNumber.Text = String.Empty;
            txtUpdCvc.Text = String.Empty;
            cbbUpdExpireMonth.SelectedIndex = -1;
            cbbUpdExpireYear.SelectedIndex = -1;
            txtUpdLimit.Text = String.Empty;
        }

        private void ClearDelForm()
        {
            txtDelId.Text = String.Empty;
            cbbDelFlag.SelectedIndex = -1;
            txtDelNumber.Text = String.Empty;
            txtDelCvc.Text = String.Empty;
            cbbDelExpireMonth.SelectedIndex = -1;
            cbbDelExpireYear.SelectedIndex = -1;
            txtDelLimit.Text = String.Empty;
        }

        private void dgvSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TabPageState(tabContentUpdate, true);
            TabPageState(tabContentDelete, true);

            var card = dgvSearch.CurrentRow.DataBoundItem as Card;

            txtUpdId.Text = card.Id.ToString();

            cbbUpdFlag.SelectedIndex = GetFlags().IndexOf(card.Flag.Name);
            txtUpdNumber.Text = card.Number;
            txtUpdCvc.Text = card.Cvc;
            cbbUpdExpireMonth.SelectedIndex = GetExpireMonths().IndexOf(card.ExpireMonth);
            cbbUpdExpireYear.SelectedIndex = GetExpireYears().IndexOf(card.ExpireYear);
            txtUpdLimit.Text = card.Limit.ToString();

            txtDelId.Text = card.Id.ToString();

            cbbDelFlag.SelectedIndex = GetFlags().IndexOf(card.Flag.Name);
            txtDelNumber.Text = card.Number;
            txtDelCvc.Text = card.Cvc;
            cbbDelExpireMonth.SelectedIndex = GetExpireMonths().IndexOf(card.ExpireMonth);
            cbbDelExpireYear.SelectedIndex = GetExpireYears().IndexOf(card.ExpireYear);
            txtDelLimit.Text = card.Limit.ToString();

            CardInAction = card;

            TabSelect(tabContentUpdate);
        }

        private void TabPageState(TabPage tab, bool state)
        {
            ((Control)tab).Enabled = state;
        }

        private void TabSelect(TabPage tab)
        {
            tabPanel.SelectTab(tab);
        }

        private void BackToPrincipalTab()
        {
            TabSelect(tabContentSearch);
        }

        private void OutUpdateTab()
        {
            ClearUpdForm();

            BackToPrincipalTab();

            TabPageState(tabContentUpdate, false);
        }

        private void OutDeleteTab()
        {
            ClearDelForm();

            BackToPrincipalTab();

            TabPageState(tabContentDelete, false);
        }

        private void OutPrivateTabs()
        {
            OutUpdateTab();

            OutDeleteTab();

            CardInAction = null;
        }

        private List<Int32> GetExpireMonths()
        {
            List<Int32> months = new List<Int32>();

            foreach (var item in cbbAddExpireMonth.Items)
            {
                months.Add(Convert.ToInt32(item.ToString()));
            }

            return months;
        }

        private List<Int32> GetExpireYears()
        {
            List<Int32> years = new List<Int32>();

            foreach (var item in cbbAddExpireYear.Items)
            {
                years.Add(Convert.ToInt32(item.ToString()));
            }

            return years;
        }

        private List<String> GetFlags()
        {
            List<String> flags = new List<String>();

            foreach (var flag in LoadFlags())
            {
                flags.Add(((Flag)flag).Name);
            }

            return flags;
        }
    }
}
