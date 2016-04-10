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
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gpbFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.rdbFilter_Id = new System.Windows.Forms.RadioButton();
            this.rdbFilter_Number = new System.Windows.Forms.RadioButton();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.cbbAddFlag = new System.Windows.Forms.ComboBox();
            this.lblAddFlag = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.txtAddNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblExpireMonth = new System.Windows.Forms.Label();
            this.cbbAddExpireMonth = new System.Windows.Forms.ComboBox();
            this.lblExpireYear = new System.Windows.Forms.Label();
            this.cbbAddExpireYear = new System.Windows.Forms.ComboBox();
            this.txtAddCvc = new System.Windows.Forms.MaskedTextBox();
            this.lblCvc = new System.Windows.Forms.Label();
            this.txtAddLimit = new System.Windows.Forms.MaskedTextBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.tabPanel.SuspendLayout();
            this.tabContentSearch.SuspendLayout();
            this.tabContentAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.gpbFilter.SuspendLayout();
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
            this.tabContentSearch.Controls.Add(this.btnFilter);
            this.tabContentSearch.Controls.Add(this.gpbFilter);
            this.tabContentSearch.Controls.Add(this.btnUpdate);
            this.tabContentSearch.Controls.Add(this.dgvSearch);
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
            this.tabContentAdd.Controls.Add(this.txtAddLimit);
            this.tabContentAdd.Controls.Add(this.lblLimit);
            this.tabContentAdd.Controls.Add(this.txtAddCvc);
            this.tabContentAdd.Controls.Add(this.lblCvc);
            this.tabContentAdd.Controls.Add(this.lblExpireYear);
            this.tabContentAdd.Controls.Add(this.cbbAddExpireYear);
            this.tabContentAdd.Controls.Add(this.lblExpireMonth);
            this.tabContentAdd.Controls.Add(this.cbbAddExpireMonth);
            this.tabContentAdd.Controls.Add(this.txtAddNumber);
            this.tabContentAdd.Controls.Add(this.lblAddNumber);
            this.tabContentAdd.Controls.Add(this.btnAddCancel);
            this.tabContentAdd.Controls.Add(this.btnAddSave);
            this.tabContentAdd.Controls.Add(this.lblAddFlag);
            this.tabContentAdd.Controls.Add(this.cbbAddFlag);
            this.tabContentAdd.Controls.Add(this.txtOwner);
            this.tabContentAdd.Controls.Add(this.lblOwner);
            this.tabContentAdd.Location = new System.Drawing.Point(4, 26);
            this.tabContentAdd.Name = "tabContentAdd";
            this.tabContentAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabContentAdd.Size = new System.Drawing.Size(710, 348);
            this.tabContentAdd.TabIndex = 1;
            this.tabContentAdd.Text = "Adicionar";
            this.tabContentAdd.UseVisualStyleBackColor = true;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(3, 103);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(698, 239);
            this.dgvSearch.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(617, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gpbFilter
            // 
            this.gpbFilter.Controls.Add(this.txtFilter);
            this.gpbFilter.Controls.Add(this.lblFilter);
            this.gpbFilter.Controls.Add(this.lblColumns);
            this.gpbFilter.Controls.Add(this.rdbFilter_Number);
            this.gpbFilter.Controls.Add(this.rdbFilter_Id);
            this.gpbFilter.Location = new System.Drawing.Point(6, 3);
            this.gpbFilter.Name = "gpbFilter";
            this.gpbFilter.Size = new System.Drawing.Size(605, 94);
            this.gpbFilter.TabIndex = 2;
            this.gpbFilter.TabStop = false;
            this.gpbFilter.Text = "Filtros";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(617, 22);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(84, 33);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // rdbFilter_Id
            // 
            this.rdbFilter_Id.AutoSize = true;
            this.rdbFilter_Id.Location = new System.Drawing.Point(9, 55);
            this.rdbFilter_Id.Name = "rdbFilter_Id";
            this.rdbFilter_Id.Size = new System.Drawing.Size(37, 21);
            this.rdbFilter_Id.TabIndex = 0;
            this.rdbFilter_Id.Text = "Id";
            this.rdbFilter_Id.UseVisualStyleBackColor = true;
            // 
            // rdbFilter_Number
            // 
            this.rdbFilter_Number.AutoSize = true;
            this.rdbFilter_Number.Checked = true;
            this.rdbFilter_Number.Location = new System.Drawing.Point(52, 55);
            this.rdbFilter_Number.Name = "rdbFilter_Number";
            this.rdbFilter_Number.Size = new System.Drawing.Size(74, 21);
            this.rdbFilter_Number.TabIndex = 1;
            this.rdbFilter_Number.TabStop = true;
            this.rdbFilter_Number.Text = "Número";
            this.rdbFilter_Number.UseVisualStyleBackColor = true;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(6, 35);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(54, 17);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Colunas";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(182, 38);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(37, 17);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filtro";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(185, 55);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(414, 25);
            this.txtFilter.TabIndex = 4;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(6, 3);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(81, 17);
            this.lblOwner.TabIndex = 0;
            this.lblOwner.Text = "Responsável";
            // 
            // txtOwner
            // 
            this.txtOwner.Enabled = false;
            this.txtOwner.Location = new System.Drawing.Point(7, 24);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(344, 25);
            this.txtOwner.TabIndex = 1;
            // 
            // cbbAddFlag
            // 
            this.cbbAddFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddFlag.FormattingEnabled = true;
            this.cbbAddFlag.Location = new System.Drawing.Point(6, 90);
            this.cbbAddFlag.Name = "cbbAddFlag";
            this.cbbAddFlag.Size = new System.Drawing.Size(151, 25);
            this.cbbAddFlag.TabIndex = 2;
            // 
            // lblAddFlag
            // 
            this.lblAddFlag.AutoSize = true;
            this.lblAddFlag.Location = new System.Drawing.Point(6, 70);
            this.lblAddFlag.Name = "lblAddFlag";
            this.lblAddFlag.Size = new System.Drawing.Size(59, 17);
            this.lblAddFlag.TabIndex = 3;
            this.lblAddFlag.Text = "Bandeira";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(613, 310);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(91, 32);
            this.btnAddSave.TabIndex = 4;
            this.btnAddSave.Text = "Salvar";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(6, 310);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(91, 32);
            this.btnAddCancel.TabIndex = 5;
            this.btnAddCancel.Text = "Cancelar";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Location = new System.Drawing.Point(177, 70);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(56, 17);
            this.lblAddNumber.TabIndex = 6;
            this.lblAddNumber.Text = "Número";
            // 
            // txtAddNumber
            // 
            this.txtAddNumber.Location = new System.Drawing.Point(180, 90);
            this.txtAddNumber.Mask = "0000 0000 0000 0099";
            this.txtAddNumber.Name = "txtAddNumber";
            this.txtAddNumber.Size = new System.Drawing.Size(151, 25);
            this.txtAddNumber.TabIndex = 7;
            // 
            // lblExpireMonth
            // 
            this.lblExpireMonth.AutoSize = true;
            this.lblExpireMonth.Location = new System.Drawing.Point(3, 134);
            this.lblExpireMonth.Name = "lblExpireMonth";
            this.lblExpireMonth.Size = new System.Drawing.Size(123, 17);
            this.lblExpireMonth.TabIndex = 9;
            this.lblExpireMonth.Text = "Mês de Vencimento";
            // 
            // cbbAddExpireMonth
            // 
            this.cbbAddExpireMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddExpireMonth.FormattingEnabled = true;
            this.cbbAddExpireMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbAddExpireMonth.Location = new System.Drawing.Point(6, 154);
            this.cbbAddExpireMonth.Name = "cbbAddExpireMonth";
            this.cbbAddExpireMonth.Size = new System.Drawing.Size(151, 25);
            this.cbbAddExpireMonth.TabIndex = 8;
            // 
            // lblExpireYear
            // 
            this.lblExpireYear.AutoSize = true;
            this.lblExpireYear.Location = new System.Drawing.Point(177, 134);
            this.lblExpireYear.Name = "lblExpireYear";
            this.lblExpireYear.Size = new System.Drawing.Size(121, 17);
            this.lblExpireYear.TabIndex = 11;
            this.lblExpireYear.Text = "Ano de Vencimento";
            // 
            // cbbAddExpireYear
            // 
            this.cbbAddExpireYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddExpireYear.FormattingEnabled = true;
            this.cbbAddExpireYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbbAddExpireYear.Location = new System.Drawing.Point(180, 154);
            this.cbbAddExpireYear.Name = "cbbAddExpireYear";
            this.cbbAddExpireYear.Size = new System.Drawing.Size(151, 25);
            this.cbbAddExpireYear.TabIndex = 10;
            // 
            // txtAddCvc
            // 
            this.txtAddCvc.Location = new System.Drawing.Point(356, 90);
            this.txtAddCvc.Mask = "000";
            this.txtAddCvc.Name = "txtAddCvc";
            this.txtAddCvc.Size = new System.Drawing.Size(79, 25);
            this.txtAddCvc.TabIndex = 13;
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Location = new System.Drawing.Point(353, 70);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(32, 17);
            this.lblCvc.TabIndex = 12;
            this.lblCvc.Text = "CVC";
            // 
            // txtAddLimit
            // 
            this.txtAddLimit.Location = new System.Drawing.Point(9, 222);
            this.txtAddLimit.Mask = "$ 999\\.999\\,\\0\\0";
            this.txtAddLimit.Name = "txtAddLimit";
            this.txtAddLimit.Size = new System.Drawing.Size(151, 25);
            this.txtAddLimit.TabIndex = 15;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(6, 202);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(42, 17);
            this.lblLimit.TabIndex = 14;
            this.lblLimit.Text = "Limite";
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
            this.Load += new System.EventHandler(this.WalletPanel_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabContentSearch.ResumeLayout(false);
            this.tabContentAdd.ResumeLayout(false);
            this.tabContentAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.gpbFilter.ResumeLayout(false);
            this.gpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabContentSearch;
        private System.Windows.Forms.TabPage tabContentAdd;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gpbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.RadioButton rdbFilter_Number;
        private System.Windows.Forms.RadioButton rdbFilter_Id;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblAddFlag;
        private System.Windows.Forms.ComboBox cbbAddFlag;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.MaskedTextBox txtAddNumber;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.Label lblExpireYear;
        private System.Windows.Forms.ComboBox cbbAddExpireYear;
        private System.Windows.Forms.Label lblExpireMonth;
        private System.Windows.Forms.ComboBox cbbAddExpireMonth;
        private System.Windows.Forms.MaskedTextBox txtAddLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.MaskedTextBox txtAddCvc;
        private System.Windows.Forms.Label lblCvc;
    }
}