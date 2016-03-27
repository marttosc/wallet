namespace Wallet
{
    partial class WalletForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWallet = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNewAccount = new System.Windows.Forms.Label();
            this.lnkNewAccount = new System.Windows.Forms.LinkLabel();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.Location = new System.Drawing.Point(81, 9);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(152, 45);
            this.lblWallet.TabIndex = 3;
            this.lblWallet.Text = "WALLET!";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(83, 164);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(150, 36);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.AutoSize = true;
            this.lblNewAccount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAccount.Location = new System.Drawing.Point(97, 230);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(127, 13);
            this.lblNewAccount.TabIndex = 5;
            this.lblNewAccount.Text = "Não possui uma conta?";
            // 
            // lnkNewAccount
            // 
            this.lnkNewAccount.AutoSize = true;
            this.lnkNewAccount.LinkColor = System.Drawing.Color.Maroon;
            this.lnkNewAccount.Location = new System.Drawing.Point(130, 254);
            this.lnkNewAccount.Name = "lnkNewAccount";
            this.lnkNewAccount.Size = new System.Drawing.Size(62, 13);
            this.lnkNewAccount.TabIndex = 6;
            this.lnkNewAccount.TabStop = true;
            this.lnkNewAccount.Text = "Clique aqui!";
            this.lnkNewAccount.VisitedLinkColor = System.Drawing.Color.Maroon;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtCpf.Location = new System.Drawing.Point(83, 75);
            this.txtCpf.Mask = "000\\.000\\.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(150, 33);
            this.txtCpf.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(83, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 29);
            this.txtPassword.TabIndex = 8;
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 280);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lnkNewAccount);
            this.Controls.Add(this.lblNewAccount);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblWallet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WalletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNewAccount;
        private System.Windows.Forms.LinkLabel lnkNewAccount;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

