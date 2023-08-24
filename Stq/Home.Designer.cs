namespace Stq
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.dataTabela = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRmvF = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRem = new System.Windows.Forms.Button();
            this.buttonCancelarOp = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.buttonRemProd = new System.Windows.Forms.Button();
            this.textCodAddQ = new System.Windows.Forms.TextBox();
            this.textAddQ = new System.Windows.Forms.TextBox();
            this.buttonAddQ = new System.Windows.Forms.Button();
            this.labelAddQ = new System.Windows.Forms.Label();
            this.labelAddQ2 = new System.Windows.Forms.Label();
            this.labelRemover = new System.Windows.Forms.Label();
            this.labelTotalestoque = new System.Windows.Forms.Label();
            this.buttonRmvQuant = new System.Windows.Forms.Button();
            this.buttonAlterarReg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.Pesq = new System.Windows.Forms.TextBox();
            this.labelQuantR = new System.Windows.Forms.Label();
            this.checkHist = new System.Windows.Forms.CheckBox();
            this.checkColor = new System.Windows.Forms.CheckBox();
            this.checkQuant = new System.Windows.Forms.CheckBox();
            this.pictureExcel = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.dateTimeAntes = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDepois = new System.Windows.Forms.DateTimePicker();
            this.checkData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.BackColor = System.Drawing.Color.DimGray;
            this.buttonRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegistro.Location = new System.Drawing.Point(24, 12);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(290, 57);
            this.buttonRegistro.TabIndex = 1;
            this.buttonRegistro.Text = "Registros";
            this.buttonRegistro.UseVisualStyleBackColor = false;
            this.buttonRegistro.Visible = false;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BackColor = System.Drawing.Color.DimGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(83, 603);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(167, 42);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfig.BackColor = System.Drawing.Color.DimGray;
            this.buttonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConfig.Location = new System.Drawing.Point(99, 551);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(132, 37);
            this.buttonConfig.TabIndex = 13;
            this.buttonConfig.Text = "Configurações";
            this.buttonConfig.UseVisualStyleBackColor = false;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // dataTabela
            // 
            this.dataTabela.AllowUserToAddRows = false;
            this.dataTabela.AllowUserToDeleteRows = false;
            this.dataTabela.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.dataTabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTabela.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataTabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.COR,
            this.PESO,
            this.QUANTIDADE,
            this.VALOR,
            this.TOTAL,
            this.User_,
            this.DateT});
            this.dataTabela.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTabela.EnableHeadersVisualStyles = false;
            this.dataTabela.GridColor = System.Drawing.Color.DimGray;
            this.dataTabela.Location = new System.Drawing.Point(380, 61);
            this.dataTabela.Name = "dataTabela";
            this.dataTabela.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTabela.RowHeadersVisible = false;
            this.dataTabela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTabela.Size = new System.Drawing.Size(966, 568);
            this.dataTabela.TabIndex = 17;
            this.dataTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabela_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Código de Barras";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "Produto";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // COR
            // 
            this.COR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COR.HeaderText = "Cor";
            this.COR.Name = "COR";
            this.COR.ReadOnly = true;
            // 
            // PESO
            // 
            this.PESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PESO.HeaderText = "Peso";
            this.PESO.Name = "PESO";
            this.PESO.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VALOR.HeaderText = "Preço";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // User_
            // 
            this.User_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_.HeaderText = "Alterado por:";
            this.User_.Name = "User_";
            this.User_.ReadOnly = true;
            // 
            // DateT
            // 
            this.DateT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateT.HeaderText = "Data da Alteração";
            this.DateT.Name = "DateT";
            this.DateT.ReadOnly = true;
            // 
            // buttonRmvF
            // 
            this.buttonRmvF.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonRmvF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRmvF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRmvF.ForeColor = System.Drawing.Color.Red;
            this.buttonRmvF.Location = new System.Drawing.Point(689, 6);
            this.buttonRmvF.Name = "buttonRmvF";
            this.buttonRmvF.Size = new System.Drawing.Size(33, 31);
            this.buttonRmvF.TabIndex = 8;
            this.buttonRmvF.Text = "X";
            this.buttonRmvF.UseVisualStyleBackColor = false;
            this.buttonRmvF.Visible = false;
            this.buttonRmvF.Click += new System.EventHandler(this.buttonRmvF_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPesquisar.Location = new System.Drawing.Point(597, 6);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(86, 31);
            this.buttonPesquisar.TabIndex = 16;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesq_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(24, 134);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRem
            // 
            this.buttonRem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRem.Location = new System.Drawing.Point(178, 134);
            this.buttonRem.Name = "buttonRem";
            this.buttonRem.Size = new System.Drawing.Size(136, 33);
            this.buttonRem.TabIndex = 3;
            this.buttonRem.Text = "Remover";
            this.buttonRem.UseVisualStyleBackColor = false;
            this.buttonRem.Visible = false;
            this.buttonRem.Click += new System.EventHandler(this.buttonRem_Click);
            // 
            // buttonCancelarOp
            // 
            this.buttonCancelarOp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelarOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarOp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelarOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarOp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelarOp.Location = new System.Drawing.Point(121, 224);
            this.buttonCancelarOp.Name = "buttonCancelarOp";
            this.buttonCancelarOp.Size = new System.Drawing.Size(92, 20);
            this.buttonCancelarOp.TabIndex = 4;
            this.buttonCancelarOp.Text = "Cancelar";
            this.buttonCancelarOp.UseVisualStyleBackColor = false;
            this.buttonCancelarOp.Visible = false;
            this.buttonCancelarOp.Click += new System.EventHandler(this.buttonCancelarOp_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddProd.Location = new System.Drawing.Point(24, 173);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(136, 45);
            this.buttonAddProd.TabIndex = 6;
            this.buttonAddProd.Text = "Adicionar Produto";
            this.buttonAddProd.UseVisualStyleBackColor = false;
            this.buttonAddProd.Visible = false;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // buttonRemProd
            // 
            this.buttonRemProd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRemProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemProd.Location = new System.Drawing.Point(178, 173);
            this.buttonRemProd.Name = "buttonRemProd";
            this.buttonRemProd.Size = new System.Drawing.Size(136, 45);
            this.buttonRemProd.TabIndex = 7;
            this.buttonRemProd.Text = "Remover Produto";
            this.buttonRemProd.UseVisualStyleBackColor = false;
            this.buttonRemProd.Visible = false;
            this.buttonRemProd.Click += new System.EventHandler(this.buttonRemProd_Click);
            // 
            // textCodAddQ
            // 
            this.textCodAddQ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textCodAddQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCodAddQ.ForeColor = System.Drawing.SystemColors.Info;
            this.textCodAddQ.Location = new System.Drawing.Point(100, 267);
            this.textCodAddQ.Name = "textCodAddQ";
            this.textCodAddQ.Size = new System.Drawing.Size(131, 20);
            this.textCodAddQ.TabIndex = 8;
            this.textCodAddQ.Visible = false;
            this.textCodAddQ.TextChanged += new System.EventHandler(this.textCodAddQ_TextChanged);
            this.textCodAddQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodAddQ_KeyPress);
            this.textCodAddQ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCodAddQ_KeyUp);
            // 
            // textAddQ
            // 
            this.textAddQ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textAddQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAddQ.ForeColor = System.Drawing.SystemColors.Info;
            this.textAddQ.Location = new System.Drawing.Point(100, 321);
            this.textAddQ.Name = "textAddQ";
            this.textAddQ.ShortcutsEnabled = false;
            this.textAddQ.Size = new System.Drawing.Size(131, 20);
            this.textAddQ.TabIndex = 10;
            this.textAddQ.Visible = false;
            this.textAddQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddQ_KeyPress);
            // 
            // buttonAddQ
            // 
            this.buttonAddQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddQ.Location = new System.Drawing.Point(121, 347);
            this.buttonAddQ.Name = "buttonAddQ";
            this.buttonAddQ.Size = new System.Drawing.Size(95, 30);
            this.buttonAddQ.TabIndex = 11;
            this.buttonAddQ.Text = "Adicionar";
            this.buttonAddQ.UseVisualStyleBackColor = false;
            this.buttonAddQ.Visible = false;
            this.buttonAddQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAddQ
            // 
            this.labelAddQ.AutoSize = true;
            this.labelAddQ.BackColor = System.Drawing.Color.Transparent;
            this.labelAddQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddQ.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddQ.Location = new System.Drawing.Point(141, 249);
            this.labelAddQ.Name = "labelAddQ";
            this.labelAddQ.Size = new System.Drawing.Size(52, 15);
            this.labelAddQ.TabIndex = 21;
            this.labelAddQ.Text = "Código";
            this.labelAddQ.Visible = false;
            // 
            // labelAddQ2
            // 
            this.labelAddQ2.AutoSize = true;
            this.labelAddQ2.BackColor = System.Drawing.Color.Transparent;
            this.labelAddQ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddQ2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddQ2.Location = new System.Drawing.Point(97, 295);
            this.labelAddQ2.Name = "labelAddQ2";
            this.labelAddQ2.Size = new System.Drawing.Size(137, 15);
            this.labelAddQ2.TabIndex = 22;
            this.labelAddQ2.Text = "Quantidade - Adição";
            this.labelAddQ2.Visible = false;
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.BackColor = System.Drawing.Color.Transparent;
            this.labelRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemover.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRemover.Location = new System.Drawing.Point(95, 295);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(155, 15);
            this.labelRemover.TabIndex = 23;
            this.labelRemover.Text = "Quantidade - Remoção";
            this.labelRemover.Visible = false;
            // 
            // labelTotalestoque
            // 
            this.labelTotalestoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalestoque.AutoSize = true;
            this.labelTotalestoque.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalestoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotalestoque.Location = new System.Drawing.Point(377, 645);
            this.labelTotalestoque.Name = "labelTotalestoque";
            this.labelTotalestoque.Size = new System.Drawing.Size(153, 13);
            this.labelTotalestoque.TabIndex = 24;
            this.labelTotalestoque.Text = "Valor total em estoque: R$0,00";
            this.labelTotalestoque.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRmvQuant
            // 
            this.buttonRmvQuant.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRmvQuant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRmvQuant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRmvQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRmvQuant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRmvQuant.Location = new System.Drawing.Point(121, 347);
            this.buttonRmvQuant.Name = "buttonRmvQuant";
            this.buttonRmvQuant.Size = new System.Drawing.Size(95, 30);
            this.buttonRmvQuant.TabIndex = 12;
            this.buttonRmvQuant.Text = "Remover";
            this.buttonRmvQuant.UseVisualStyleBackColor = false;
            this.buttonRmvQuant.Visible = false;
            this.buttonRmvQuant.Click += new System.EventHandler(this.buttonRmvQuant_Click);
            // 
            // buttonAlterarReg
            // 
            this.buttonAlterarReg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAlterarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlterarReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarReg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAlterarReg.Location = new System.Drawing.Point(24, 84);
            this.buttonAlterarReg.Name = "buttonAlterarReg";
            this.buttonAlterarReg.Size = new System.Drawing.Size(290, 44);
            this.buttonAlterarReg.TabIndex = 5;
            this.buttonAlterarReg.Text = "Alterar Registro";
            this.buttonAlterarReg.UseVisualStyleBackColor = false;
            this.buttonAlterarReg.Visible = false;
            this.buttonAlterarReg.Click += new System.EventHandler(this.buttonEditReg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImage = global::Stq.Properties.Resources.LateralInc1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 749);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(121, 295);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 30);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Pesq
            // 
            this.Pesq.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Pesq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pesq.ForeColor = System.Drawing.SystemColors.Window;
            this.Pesq.Location = new System.Drawing.Point(380, 12);
            this.Pesq.MaxLength = 30;
            this.Pesq.Name = "Pesq";
            this.Pesq.Size = new System.Drawing.Size(211, 20);
            this.Pesq.TabIndex = 25;
            this.Pesq.TextChanged += new System.EventHandler(this.Pesq_TextChanged);
            // 
            // labelQuantR
            // 
            this.labelQuantR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelQuantR.AutoSize = true;
            this.labelQuantR.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelQuantR.Location = new System.Drawing.Point(377, 632);
            this.labelQuantR.Name = "labelQuantR";
            this.labelQuantR.Size = new System.Drawing.Size(113, 13);
            this.labelQuantR.TabIndex = 26;
            this.labelQuantR.Text = "Registros no estoque: ";
            // 
            // checkHist
            // 
            this.checkHist.AutoSize = true;
            this.checkHist.BackColor = System.Drawing.Color.Transparent;
            this.checkHist.ForeColor = System.Drawing.SystemColors.Control;
            this.checkHist.Location = new System.Drawing.Point(706, 41);
            this.checkHist.Name = "checkHist";
            this.checkHist.Size = new System.Drawing.Size(95, 17);
            this.checkHist.TabIndex = 27;
            this.checkHist.Text = "Exibir Histórico";
            this.checkHist.UseVisualStyleBackColor = false;
            this.checkHist.Visible = false;
            this.checkHist.CheckedChanged += new System.EventHandler(this.checkHist_CheckedChanged);
            // 
            // checkColor
            // 
            this.checkColor.AutoSize = true;
            this.checkColor.BackColor = System.Drawing.Color.Transparent;
            this.checkColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkColor.Location = new System.Drawing.Point(380, 41);
            this.checkColor.Name = "checkColor";
            this.checkColor.Size = new System.Drawing.Size(88, 17);
            this.checkColor.TabIndex = 30;
            this.checkColor.Text = "Filtrar por Cor";
            this.checkColor.UseVisualStyleBackColor = false;
            this.checkColor.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkQuant
            // 
            this.checkQuant.AutoSize = true;
            this.checkQuant.BackColor = System.Drawing.Color.Transparent;
            this.checkQuant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkQuant.Location = new System.Drawing.Point(474, 41);
            this.checkQuant.Name = "checkQuant";
            this.checkQuant.Size = new System.Drawing.Size(127, 17);
            this.checkQuant.TabIndex = 31;
            this.checkQuant.Text = "Filtrar por Quantidade";
            this.checkQuant.UseVisualStyleBackColor = false;
            this.checkQuant.CheckedChanged += new System.EventHandler(this.checkQuant_CheckedChanged);
            // 
            // pictureExcel
            // 
            this.pictureExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureExcel.BackColor = System.Drawing.Color.Transparent;
            this.pictureExcel.BackgroundImage = global::Stq.Properties.Resources.excel_icon_1610661;
            this.pictureExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureExcel.Location = new System.Drawing.Point(1260, 635);
            this.pictureExcel.Name = "pictureExcel";
            this.pictureExcel.Size = new System.Drawing.Size(40, 40);
            this.pictureExcel.TabIndex = 33;
            this.pictureExcel.TabStop = false;
            this.pictureExcel.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Stq.Properties.Resources.iconfinder_print_4341315_120555;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(1306, 635);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textMin
            // 
            this.textMin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMin.ForeColor = System.Drawing.SystemColors.Window;
            this.textMin.Location = new System.Drawing.Point(408, 12);
            this.textMin.MaxLength = 30;
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(72, 20);
            this.textMin.TabIndex = 35;
            this.textMin.Visible = false;
            this.textMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMin_KeyPress);
            // 
            // textMax
            // 
            this.textMax.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMax.ForeColor = System.Drawing.SystemColors.Window;
            this.textMax.Location = new System.Drawing.Point(519, 12);
            this.textMax.MaxLength = 30;
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(72, 20);
            this.textMax.TabIndex = 36;
            this.textMax.Visible = false;
            this.textMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMin_KeyPress);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMin.Location = new System.Drawing.Point(378, 19);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 37;
            this.labelMin.Text = "Min";
            this.labelMin.Visible = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.BackColor = System.Drawing.Color.Transparent;
            this.labelMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMax.Location = new System.Drawing.Point(486, 19);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 38;
            this.labelMax.Text = "Max";
            this.labelMax.Visible = false;
            // 
            // dateTimeAntes
            // 
            this.dateTimeAntes.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimeAntes.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimeAntes.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dateTimeAntes.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimeAntes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAntes.Location = new System.Drawing.Point(728, 12);
            this.dateTimeAntes.Name = "dateTimeAntes";
            this.dateTimeAntes.Size = new System.Drawing.Size(98, 20);
            this.dateTimeAntes.TabIndex = 39;
            this.dateTimeAntes.Visible = false;
            // 
            // dateTimeDepois
            // 
            this.dateTimeDepois.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDepois.Location = new System.Drawing.Point(832, 12);
            this.dateTimeDepois.Name = "dateTimeDepois";
            this.dateTimeDepois.Size = new System.Drawing.Size(97, 20);
            this.dateTimeDepois.TabIndex = 40;
            this.dateTimeDepois.Visible = false;
            // 
            // checkData
            // 
            this.checkData.AutoSize = true;
            this.checkData.BackColor = System.Drawing.Color.Transparent;
            this.checkData.ForeColor = System.Drawing.SystemColors.Control;
            this.checkData.Location = new System.Drawing.Point(607, 41);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(93, 17);
            this.checkData.TabIndex = 41;
            this.checkData.Text = "Filtrar por data";
            this.checkData.UseVisualStyleBackColor = false;
            this.checkData.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stq.Properties.Resources.BackgroundInic_;
            this.ClientSize = new System.Drawing.Size(1370, 689);
            this.Controls.Add(this.checkData);
            this.Controls.Add(this.dateTimeDepois);
            this.Controls.Add(this.dateTimeAntes);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureExcel);
            this.Controls.Add(this.checkQuant);
            this.Controls.Add(this.checkColor);
            this.Controls.Add(this.checkHist);
            this.Controls.Add(this.labelQuantR);
            this.Controls.Add(this.Pesq);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAlterarReg);
            this.Controls.Add(this.buttonRmvQuant);
            this.Controls.Add(this.labelTotalestoque);
            this.Controls.Add(this.labelRemover);
            this.Controls.Add(this.labelAddQ2);
            this.Controls.Add(this.labelAddQ);
            this.Controls.Add(this.buttonAddQ);
            this.Controls.Add(this.textAddQ);
            this.Controls.Add(this.textCodAddQ);
            this.Controls.Add(this.buttonRemProd);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.buttonCancelarOp);
            this.Controls.Add(this.buttonRem);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonRmvF);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataTabela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.DataGridView dataTabela;
        private System.Windows.Forms.Button buttonRmvF;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRem;
        private System.Windows.Forms.Button buttonCancelarOp;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.Button buttonRemProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textCodAddQ;
        private System.Windows.Forms.TextBox textAddQ;
        private System.Windows.Forms.Button buttonAddQ;
        private System.Windows.Forms.Label labelAddQ;
        private System.Windows.Forms.Label labelAddQ2;
        private System.Windows.Forms.Label labelRemover;
        private System.Windows.Forms.Label labelTotalestoque;
        private System.Windows.Forms.Button buttonRmvQuant;
        private System.Windows.Forms.Button buttonAlterarReg;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox Pesq;
        private System.Windows.Forms.Label labelQuantR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateT;
        private System.Windows.Forms.CheckBox checkHist;
        private System.Windows.Forms.CheckBox checkColor;
        private System.Windows.Forms.CheckBox checkQuant;
        private System.Windows.Forms.PictureBox pictureExcel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.DateTimePicker dateTimeAntes;
        private System.Windows.Forms.DateTimePicker dateTimeDepois;
        private System.Windows.Forms.CheckBox checkData;
    }
}