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
            this.buttonRmvF = new System.Windows.Forms.Button();
            this.textPesquisa = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(24, 93);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(290, 52);
            this.buttonRegistro.TabIndex = 1;
            this.buttonRegistro.Text = "Registros";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Location = new System.Drawing.Point(103, 595);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 34);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfig.Location = new System.Drawing.Point(122, 560);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(88, 29);
            this.buttonConfig.TabIndex = 5;
            this.buttonConfig.Text = "Configurações";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // dataTabela
            // 
            this.dataTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.COR,
            this.PESO,
            this.QUANTIDADE,
            this.VALOR,
            this.TOTAL});
            this.dataTabela.Location = new System.Drawing.Point(380, 61);
            this.dataTabela.Name = "dataTabela";
            this.dataTabela.RowHeadersVisible = false;
            this.dataTabela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTabela.Size = new System.Drawing.Size(966, 568);
            this.dataTabela.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "Código de Barras";
            this.ID.Name = "ID";
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "Produto";
            this.NOME.Name = "NOME";
            // 
            // COR
            // 
            this.COR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COR.HeaderText = "Cor";
            this.COR.Name = "COR";
            // 
            // PESO
            // 
            this.PESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PESO.HeaderText = "Peso";
            this.PESO.Name = "PESO";
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.Name = "QUANTIDADE";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Preço";
            this.VALOR.Name = "VALOR";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            // 
            // buttonRmvF
            // 
            this.buttonRmvF.Location = new System.Drawing.Point(621, 20);
            this.buttonRmvF.Name = "buttonRmvF";
            this.buttonRmvF.Size = new System.Drawing.Size(175, 29);
            this.buttonRmvF.TabIndex = 8;
            this.buttonRmvF.Text = "Remover Filtro";
            this.buttonRmvF.UseVisualStyleBackColor = true;
            this.buttonRmvF.Visible = false;
            this.buttonRmvF.Click += new System.EventHandler(this.buttonRmvF_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(380, 25);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(235, 20);
            this.textPesquisa.TabIndex = 9;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(621, 20);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(175, 29);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesq_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(24, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 33);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRem
            // 
            this.buttonRem.Location = new System.Drawing.Point(178, 151);
            this.buttonRem.Name = "buttonRem";
            this.buttonRem.Size = new System.Drawing.Size(136, 33);
            this.buttonRem.TabIndex = 14;
            this.buttonRem.Text = "Remover";
            this.buttonRem.UseVisualStyleBackColor = true;
            this.buttonRem.Visible = false;
            this.buttonRem.Click += new System.EventHandler(this.buttonRem_Click);
            // 
            // buttonCancelarOp
            // 
            this.buttonCancelarOp.Location = new System.Drawing.Point(126, 190);
            this.buttonCancelarOp.Name = "buttonCancelarOp";
            this.buttonCancelarOp.Size = new System.Drawing.Size(92, 20);
            this.buttonCancelarOp.TabIndex = 15;
            this.buttonCancelarOp.Text = "Cancelar";
            this.buttonCancelarOp.UseVisualStyleBackColor = true;
            this.buttonCancelarOp.Visible = false;
            this.buttonCancelarOp.Click += new System.EventHandler(this.buttonCancelarOp_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Location = new System.Drawing.Point(24, 276);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(136, 45);
            this.buttonAddProd.TabIndex = 16;
            this.buttonAddProd.Text = "Adicionar Produto";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Visible = false;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // buttonRemProd
            // 
            this.buttonRemProd.Location = new System.Drawing.Point(178, 276);
            this.buttonRemProd.Name = "buttonRemProd";
            this.buttonRemProd.Size = new System.Drawing.Size(136, 45);
            this.buttonRemProd.TabIndex = 17;
            this.buttonRemProd.Text = "Remover Produto";
            this.buttonRemProd.UseVisualStyleBackColor = true;
            this.buttonRemProd.Visible = false;
            this.buttonRemProd.Click += new System.EventHandler(this.buttonRemProd_Click);
            // 
            // textCodAddQ
            // 
            this.textCodAddQ.Location = new System.Drawing.Point(120, 350);
            this.textCodAddQ.Name = "textCodAddQ";
            this.textCodAddQ.Size = new System.Drawing.Size(100, 20);
            this.textCodAddQ.TabIndex = 18;
            this.textCodAddQ.Visible = false;
            this.textCodAddQ.TextChanged += new System.EventHandler(this.textCodAddQ_TextChanged);
            this.textCodAddQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodAddQ_KeyPress);
            // 
            // textAddQ
            // 
            this.textAddQ.Location = new System.Drawing.Point(120, 386);
            this.textAddQ.Name = "textAddQ";
            this.textAddQ.ShortcutsEnabled = false;
            this.textAddQ.Size = new System.Drawing.Size(100, 20);
            this.textAddQ.TabIndex = 19;
            this.textAddQ.Visible = false;
            // 
            // buttonAddQ
            // 
            this.buttonAddQ.Location = new System.Drawing.Point(123, 412);
            this.buttonAddQ.Name = "buttonAddQ";
            this.buttonAddQ.Size = new System.Drawing.Size(95, 30);
            this.buttonAddQ.TabIndex = 20;
            this.buttonAddQ.Text = "Adicionar";
            this.buttonAddQ.UseVisualStyleBackColor = true;
            this.buttonAddQ.Visible = false;
            this.buttonAddQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAddQ
            // 
            this.labelAddQ.AutoSize = true;
            this.labelAddQ.Location = new System.Drawing.Point(128, 334);
            this.labelAddQ.Name = "labelAddQ";
            this.labelAddQ.Size = new System.Drawing.Size(87, 13);
            this.labelAddQ.TabIndex = 21;
            this.labelAddQ.Text = "Código de barras";
            this.labelAddQ.Visible = false;
            // 
            // labelAddQ2
            // 
            this.labelAddQ2.AutoSize = true;
            this.labelAddQ2.Location = new System.Drawing.Point(97, 373);
            this.labelAddQ2.Name = "labelAddQ2";
            this.labelAddQ2.Size = new System.Drawing.Size(158, 13);
            this.labelAddQ2.TabIndex = 22;
            this.labelAddQ2.Text = "Quantidade para ser adicionada";
            this.labelAddQ2.Visible = false;
            // 
            // labelRemover
            // 
            this.labelRemover.AutoSize = true;
            this.labelRemover.Location = new System.Drawing.Point(97, 373);
            this.labelRemover.Name = "labelRemover";
            this.labelRemover.Size = new System.Drawing.Size(154, 13);
            this.labelRemover.TabIndex = 23;
            this.labelRemover.Text = "Quantidade para ser Removido";
            this.labelRemover.Visible = false;
            // 
            // labelTotalestoque
            // 
            this.labelTotalestoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalestoque.AutoSize = true;
            this.labelTotalestoque.Location = new System.Drawing.Point(1168, 632);
            this.labelTotalestoque.Name = "labelTotalestoque";
            this.labelTotalestoque.Size = new System.Drawing.Size(153, 13);
            this.labelTotalestoque.TabIndex = 24;
            this.labelTotalestoque.Text = "Valor total em estoque: R$0,00";
            this.labelTotalestoque.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRmvQuant
            // 
            this.buttonRmvQuant.Location = new System.Drawing.Point(123, 412);
            this.buttonRmvQuant.Name = "buttonRmvQuant";
            this.buttonRmvQuant.Size = new System.Drawing.Size(95, 30);
            this.buttonRmvQuant.TabIndex = 25;
            this.buttonRmvQuant.Text = "Remover";
            this.buttonRmvQuant.UseVisualStyleBackColor = true;
            this.buttonRmvQuant.Visible = false;
            this.buttonRmvQuant.Click += new System.EventHandler(this.buttonRmvQuant_Click);
            // 
            // buttonAlterarReg
            // 
            this.buttonAlterarReg.Location = new System.Drawing.Point(24, 216);
            this.buttonAlterarReg.Name = "buttonAlterarReg";
            this.buttonAlterarReg.Size = new System.Drawing.Size(290, 44);
            this.buttonAlterarReg.TabIndex = 26;
            this.buttonAlterarReg.Text = "Alterar Registro";
            this.buttonAlterarReg.UseVisualStyleBackColor = true;
            this.buttonAlterarReg.Visible = false;
            this.buttonAlterarReg.Click += new System.EventHandler(this.buttonEditReg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 749);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 689);
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
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.buttonRmvF);
            this.Controls.Add(this.dataTabela);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1386, 728);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button buttonRmvF;
        private System.Windows.Forms.TextBox textPesquisa;
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
    }
}