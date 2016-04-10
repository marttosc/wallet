using Domain.Models;
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

        private void WalletPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetLoginForm().Close();
        }
    }
}
