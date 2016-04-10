namespace View
{
    partial class WalletPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabContentSearch = new System.Windows.Forms.TabPage();
            this.tabContentAdd = new System.Windows.Forms.TabPage();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabContentSearch);
            this.tabPanel.Controls.Add(this.tabContentAdd);
            this.tabPanel.Location = new System.Drawing.Point(12, 12);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(718, 378);
            this.tabPanel.TabIndex = 0;
            // 
            // tabContentSearch
            // 
            this.tabContentSearch.Location = new System.Drawing.Point(4, 26);
            this.tabContentSearch.Name = "tabContentSearch";
            this.tabContentSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabContentSearch.Size = new System.Drawing.Size(710, 348);
            this.tabContentSearch.TabIndex = 0;
            this.tabContentSearch.Text = "Pesquisar";
            this.tabContentSearch.UseVisualStyleBackColor = true;
            // 
            // tabContentAdd
            // 
            this.tabContentAdd.Location = new System.Drawing.Point(4, 26);
            this.tabContentAdd.Name = "tabContentAdd";
            this.tabContentAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabContentAdd.Size = new System.Drawing.Size(710, 348);
            this.tabContentAdd.TabIndex = 1;
            this.tabContentAdd.Text = "Adicionar";
            this.tabContentAdd.UseVisualStyleBackColor = true;
            // 
            // WalletPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.Controls.Add(this.tabPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WalletPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel - Wallet!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WalletPanel_FormClosing);
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabContentSearch;
        private System.Windows.Forms.TabPage tabContentAdd;
    }
}