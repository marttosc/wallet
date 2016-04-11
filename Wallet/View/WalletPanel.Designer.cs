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
            this.tabContentUpdate = new System.Windows.Forms.TabPage();
            this.txtUpdLimit = new System.Windows.Forms.MaskedTextBox();
            this.lblUpdLimit = new System.Windows.Forms.Label();
            this.txtUpdCvc = new System.Windows.Forms.MaskedTextBox();
            this.lblUpdCvc = new System.Windows.Forms.Label();
            this.lblUpdExpireYear = new System.Windows.Forms.Label();
            this.cbbUpdExpireYear = new System.Windows.Forms.ComboBox();
            this.lblUpdExpireMonth = new System.Windows.Forms.Label();
            this.cbbUpdExpireMonth = new System.Windows.Forms.ComboBox();
            this.txtUpdNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblUpdNumber = new System.Windows.Forms.Label();
            this.btnUpdCancel = new System.Windows.Forms.Button();
            this.btnUpdSave = new System.Windows.Forms.Button();
            this.lblUpdFlag = new System.Windows.Forms.Label();
            this.cbbUpdFlag = new System.Windows.Forms.ComboBox();
            this.txtUpdId = new System.Windows.Forms.TextBox();
            this.lblUpdId = new System.Windows.Forms.Label();
            this.tabPanel.SuspendLayout();
            this.tabContentSearch.SuspendLayout();
            this.tabContentAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.gpbFilter.SuspendLayout();
            this.tabContentUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabContentSearch);
            this.tabPanel.Controls.Add(this.tabContentAdd);
            this.tabPanel.Controls.Add(this.tabContentUpdate);
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
            this.dgvSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_RowHeaderMouseClick);
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
            this.txtOwner.ReadOnly = true;
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
            // tabContentUpdate
            // 
            this.tabContentUpdate.Controls.Add(this.txtUpdId);
            this.tabContentUpdate.Controls.Add(this.lblUpdId);
            this.tabContentUpdate.Controls.Add(this.txtUpdLimit);
            this.tabContentUpdate.Controls.Add(this.lblUpdLimit);
            this.tabContentUpdate.Controls.Add(this.txtUpdCvc);
            this.tabContentUpdate.Controls.Add(this.lblUpdCvc);
            this.tabContentUpdate.Controls.Add(this.lblUpdExpireYear);
            this.tabContentUpdate.Controls.Add(this.cbbUpdExpireYear);
            this.tabContentUpdate.Controls.Add(this.lblUpdExpireMonth);
            this.tabContentUpdate.Controls.Add(this.cbbUpdExpireMonth);
            this.tabContentUpdate.Controls.Add(this.txtUpdNumber);
            this.tabContentUpdate.Controls.Add(this.lblUpdNumber);
            this.tabContentUpdate.Controls.Add(this.btnUpdCancel);
            this.tabContentUpdate.Controls.Add(this.btnUpdSave);
            this.tabContentUpdate.Controls.Add(this.lblUpdFlag);
            this.tabContentUpdate.Controls.Add(this.cbbUpdFlag);
            this.tabContentUpdate.Location = new System.Drawing.Point(4, 26);
            this.tabContentUpdate.Name = "tabContentUpdate";
            this.tabContentUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabContentUpdate.Size = new System.Drawing.Size(710, 348);
            this.tabContentUpdate.TabIndex = 2;
            this.tabContentUpdate.Text = "Atualizar";
            this.tabContentUpdate.UseVisualStyleBackColor = true;
            // 
            // txtUpdLimit
            // 
            this.txtUpdLimit.Location = new System.Drawing.Point(9, 223);
            this.txtUpdLimit.Mask = "$ 999\\.999\\,\\0\\0";
            this.txtUpdLimit.Name = "txtUpdLimit";
            this.txtUpdLimit.Size = new System.Drawing.Size(151, 25);
            this.txtUpdLimit.TabIndex = 29;
            // 
            // lblUpdLimit
            // 
            this.lblUpdLimit.AutoSize = true;
            this.lblUpdLimit.Location = new System.Drawing.Point(6, 203);
            this.lblUpdLimit.Name = "lblUpdLimit";
            this.lblUpdLimit.Size = new System.Drawing.Size(42, 17);
            this.lblUpdLimit.TabIndex = 28;
            this.lblUpdLimit.Text = "Limite";
            // 
            // txtUpdCvc
            // 
            this.txtUpdCvc.Location = new System.Drawing.Point(356, 91);
            this.txtUpdCvc.Mask = "000";
            this.txtUpdCvc.Name = "txtUpdCvc";
            this.txtUpdCvc.Size = new System.Drawing.Size(79, 25);
            this.txtUpdCvc.TabIndex = 27;
            // 
            // lblUpdCvc
            // 
            this.lblUpdCvc.AutoSize = true;
            this.lblUpdCvc.Location = new System.Drawing.Point(353, 71);
            this.lblUpdCvc.Name = "lblUpdCvc";
            this.lblUpdCvc.Size = new System.Drawing.Size(32, 17);
            this.lblUpdCvc.TabIndex = 26;
            this.lblUpdCvc.Text = "CVC";
            // 
            // lblUpdExpireYear
            // 
            this.lblUpdExpireYear.AutoSize = true;
            this.lblUpdExpireYear.Location = new System.Drawing.Point(177, 135);
            this.lblUpdExpireYear.Name = "lblUpdExpireYear";
            this.lblUpdExpireYear.Size = new System.Drawing.Size(121, 17);
            this.lblUpdExpireYear.TabIndex = 25;
            this.lblUpdExpireYear.Text = "Ano de Vencimento";
            // 
            // cbbUpdExpireYear
            // 
            this.cbbUpdExpireYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUpdExpireYear.FormattingEnabled = true;
            this.cbbUpdExpireYear.Items.AddRange(new object[] {
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
            this.cbbUpdExpireYear.Location = new System.Drawing.Point(180, 155);
            this.cbbUpdExpireYear.Name = "cbbUpdExpireYear";
            this.cbbUpdExpireYear.Size = new System.Drawing.Size(151, 25);
            this.cbbUpdExpireYear.TabIndex = 24;
            // 
            // lblUpdExpireMonth
            // 
            this.lblUpdExpireMonth.AutoSize = true;
            this.lblUpdExpireMonth.Location = new System.Drawing.Point(3, 135);
            this.lblUpdExpireMonth.Name = "lblUpdExpireMonth";
            this.lblUpdExpireMonth.Size = new System.Drawing.Size(123, 17);
            this.lblUpdExpireMonth.TabIndex = 23;
            this.lblUpdExpireMonth.Text = "Mês de Vencimento";
            // 
            // cbbUpdExpireMonth
            // 
            this.cbbUpdExpireMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUpdExpireMonth.FormattingEnabled = true;
            this.cbbUpdExpireMonth.Items.AddRange(new object[] {
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
            this.cbbUpdExpireMonth.Location = new System.Drawing.Point(6, 155);
            this.cbbUpdExpireMonth.Name = "cbbUpdExpireMonth";
            this.cbbUpdExpireMonth.Size = new System.Drawing.Size(151, 25);
            this.cbbUpdExpireMonth.TabIndex = 22;
            // 
            // txtUpdNumber
            // 
            this.txtUpdNumber.Location = new System.Drawing.Point(180, 91);
            this.txtUpdNumber.Mask = "0000 0000 0000 0099";
            this.txtUpdNumber.Name = "txtUpdNumber";
            this.txtUpdNumber.ReadOnly = true;
            this.txtUpdNumber.Size = new System.Drawing.Size(151, 25);
            this.txtUpdNumber.TabIndex = 21;
            // 
            // lblUpdNumber
            // 
            this.lblUpdNumber.AutoSize = true;
            this.lblUpdNumber.Location = new System.Drawing.Point(177, 71);
            this.lblUpdNumber.Name = "lblUpdNumber";
            this.lblUpdNumber.Size = new System.Drawing.Size(56, 17);
            this.lblUpdNumber.TabIndex = 20;
            this.lblUpdNumber.Text = "Número";
            // 
            // btnUpdCancel
            // 
            this.btnUpdCancel.Location = new System.Drawing.Point(6, 310);
            this.btnUpdCancel.Name = "btnUpdCancel";
            this.btnUpdCancel.Size = new System.Drawing.Size(91, 32);
            this.btnUpdCancel.TabIndex = 19;
            this.btnUpdCancel.Text = "Cancelar";
            this.btnUpdCancel.UseVisualStyleBackColor = true;
            this.btnUpdCancel.Click += new System.EventHandler(this.btnUpdCancel_Click);
            // 
            // btnUpdSave
            // 
            this.btnUpdSave.Location = new System.Drawing.Point(613, 310);
            this.btnUpdSave.Name = "btnUpdSave";
            this.btnUpdSave.Size = new System.Drawing.Size(91, 32);
            this.btnUpdSave.TabIndex = 18;
            this.btnUpdSave.Text = "Atualizar";
            this.btnUpdSave.UseVisualStyleBackColor = true;
            this.btnUpdSave.Click += new System.EventHandler(this.btnUpdSave_Click);
            // 
            // lblUpdFlag
            // 
            this.lblUpdFlag.AutoSize = true;
            this.lblUpdFlag.Location = new System.Drawing.Point(6, 71);
            this.lblUpdFlag.Name = "lblUpdFlag";
            this.lblUpdFlag.Size = new System.Drawing.Size(59, 17);
            this.lblUpdFlag.TabIndex = 17;
            this.lblUpdFlag.Text = "Bandeira";
            // 
            // cbbUpdFlag
            // 
            this.cbbUpdFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUpdFlag.FormattingEnabled = true;
            this.cbbUpdFlag.Location = new System.Drawing.Point(6, 91);
            this.cbbUpdFlag.Name = "cbbUpdFlag";
            this.cbbUpdFlag.Size = new System.Drawing.Size(151, 25);
            this.cbbUpdFlag.TabIndex = 16;
            // 
            // txtUpdId
            // 
            this.txtUpdId.Enabled = false;
            this.txtUpdId.Location = new System.Drawing.Point(6, 27);
            this.txtUpdId.Name = "txtUpdId";
            this.txtUpdId.ReadOnly = true;
            this.txtUpdId.Size = new System.Drawing.Size(154, 25);
            this.txtUpdId.TabIndex = 31;
            this.txtUpdId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUpdId
            // 
            this.lblUpdId.AutoSize = true;
            this.lblUpdId.Location = new System.Drawing.Point(5, 6);
            this.lblUpdId.Name = "lblUpdId";
            this.lblUpdId.Size = new System.Drawing.Size(20, 17);
            this.lblUpdId.TabIndex = 30;
            this.lblUpdId.Text = "ID";
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
            this.tabContentUpdate.ResumeLayout(false);
            this.tabContentUpdate.PerformLayout();
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
        private System.Windows.Forms.TabPage tabContentUpdate;
        private System.Windows.Forms.MaskedTextBox txtUpdLimit;
        private System.Windows.Forms.Label lblUpdLimit;
        private System.Windows.Forms.MaskedTextBox txtUpdCvc;
        private System.Windows.Forms.Label lblUpdCvc;
        private System.Windows.Forms.Label lblUpdExpireYear;
        private System.Windows.Forms.ComboBox cbbUpdExpireYear;
        private System.Windows.Forms.Label lblUpdExpireMonth;
        private System.Windows.Forms.ComboBox cbbUpdExpireMonth;
        private System.Windows.Forms.MaskedTextBox txtUpdNumber;
        private System.Windows.Forms.Label lblUpdNumber;
        private System.Windows.Forms.Button btnUpdCancel;
        private System.Windows.Forms.Button btnUpdSave;
        private System.Windows.Forms.Label lblUpdFlag;
        private System.Windows.Forms.ComboBox cbbUpdFlag;
        private System.Windows.Forms.TextBox txtUpdId;
        private System.Windows.Forms.Label lblUpdId;
    }
}