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
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.BackColor = System.Drawing.Color.DimGray;
            this.buttonRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegistro.Location = new System.Drawing.Point(24, 21);
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
            this.buttonRmvF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRmvF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRmvF.Location = new System.Drawing.Point(834, 13);
            this.buttonRmvF.Name = "buttonRmvF";
            this.buttonRmvF.Size = new System.Drawing.Size(175, 34);
            this.buttonRmvF.TabIndex = 8;
            this.buttonRmvF.Text = "Remover Filtro";
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
            this.buttonPesquisar.Location = new System.Drawing.Point(834, 14);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(175, 33);
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
            this.buttonCancelarOp.Location = new System.Drawing.Point(121, 358);
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
            this.textCodAddQ.Location = new System.Drawing.Point(100, 242);
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
            this.textAddQ.Location = new System.Drawing.Point(100, 296);
            this.textAddQ.Name = "textAddQ";
            this.textAddQ.ShortcutsEnabled = false;
            this.textAddQ.Size = new System.Drawing.Size(131, 20);
            this.textAddQ.TabIndex = 10;
            this.textAddQ.Visible = false;
            // 
            // buttonAddQ
            // 
            this.buttonAddQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddQ.Location = new System.Drawing.Point(121, 322);
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
            this.labelAddQ.Location = new System.Drawing.Point(141, 224);
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
            this.labelAddQ2.Location = new System.Drawing.Point(97, 270);
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
            this.labelRemover.Location = new System.Drawing.Point(95, 270);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(155, 15);
            this.labelRemover.TabIndex = 23;
            this.labelRemover.Text = "Quantidade - Remoção";
            this.labelRemover.Visible = false;
            // 
            // labelTotalestoque
            // 
            this.labelTotalestoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalestoque.AutoSize = true;
            this.labelTotalestoque.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalestoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotalestoque.Location = new System.Drawing.Point(1172, 632);
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
            this.buttonRmvQuant.Location = new System.Drawing.Point(222, 322);
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
            this.buttonEdit.Location = new System.Drawing.Point(121, 270);
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
            this.Pesq.Location = new System.Drawing.Point(380, 21);
            this.Pesq.Name = "Pesq";
            this.Pesq.Size = new System.Drawing.Size(448, 20);
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
            this.checkHist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkHist.AutoSize = true;
            this.checkHist.BackColor = System.Drawing.Color.Transparent;
            this.checkHist.ForeColor = System.Drawing.SystemColors.Control;
            this.checkHist.Location = new System.Drawing.Point(380, 660);
            this.checkHist.Name = "checkHist";
            this.checkHist.Size = new System.Drawing.Size(95, 17);
            this.checkHist.TabIndex = 27;
            this.checkHist.Text = "Exibir Histórico";
            this.checkHist.UseVisualStyleBackColor = false;
            this.checkHist.Visible = false;
            this.checkHist.CheckedChanged += new System.EventHandler(this.checkHist_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stq.Properties.Resources.BackgroundInic_;
            this.ClientSize = new System.Drawing.Size(1370, 689);
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
    }
}