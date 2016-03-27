using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wallet.Models;

namespace Wallet
{
    public partial class WalletForm : Form
    {
        public WalletForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            String Cpf = txtCpf.Text.Trim();
            String Password = txtPassword.Text;
        }
    }
}
