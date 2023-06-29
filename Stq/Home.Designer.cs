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
            this.checkBar = new System.Windows.Forms.CheckBox();
            this.checkQuant = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRem = new System.Windows.Forms.Button();
            this.buttonCancelarOp = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.buttonRemProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(23, 53);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(290, 52);
            this.buttonRegistro.TabIndex = 1;
            this.buttonRegistro.Text = "Registros";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(119, 919);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 38);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(108, 864);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(120, 38);
            this.buttonConfig.TabIndex = 5;
            this.buttonConfig.Text = "Configurações";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // dataTabela
            // 
            this.dataTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.COR,
            this.PESO,
            this.QUANTIDADE,
            this.VALOR,
            this.TOTAL});
            this.dataTabela.Location = new System.Drawing.Point(360, 71);
            this.dataTabela.Name = "dataTabela";
            this.dataTabela.RowHeadersVisible = false;
            this.dataTabela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTabela.Size = new System.Drawing.Size(1532, 922);
            this.dataTabela.TabIndex = 6;
            this.dataTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabela_CellContentClick);
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
            this.buttonRmvF.Location = new System.Drawing.Point(621, 12);
            this.buttonRmvF.Name = "buttonRmvF";
            this.buttonRmvF.Size = new System.Drawing.Size(175, 20);
            this.buttonRmvF.TabIndex = 8;
            this.buttonRmvF.Text = "Remover Filtro";
            this.buttonRmvF.UseVisualStyleBackColor = true;
            this.buttonRmvF.Visible = false;
            this.buttonRmvF.Click += new System.EventHandler(this.buttonRmvF_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(380, 12);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(235, 20);
            this.textPesquisa.TabIndex = 9;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(621, 12);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(175, 20);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesq_Click);
            // 
            // checkBar
            // 
            this.checkBar.AutoSize = true;
            this.checkBar.Location = new System.Drawing.Point(380, 38);
            this.checkBar.Name = "checkBar";
            this.checkBar.Size = new System.Drawing.Size(46, 17);
            this.checkBar.TabIndex = 11;
            this.checkBar.Text = "*****";
            this.checkBar.UseVisualStyleBackColor = true;
            // 
            // checkQuant
            // 
            this.checkQuant.AutoSize = true;
            this.checkQuant.Location = new System.Drawing.Point(466, 38);
            this.checkQuant.Name = "checkQuant";
            this.checkQuant.Size = new System.Drawing.Size(46, 17);
            this.checkQuant.TabIndex = 12;
            this.checkQuant.Text = "*****";
            this.checkQuant.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 111);
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
            this.buttonRem.Location = new System.Drawing.Point(177, 111);
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
            this.buttonCancelarOp.Location = new System.Drawing.Point(122, 150);
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
            this.buttonAddProd.Location = new System.Drawing.Point(23, 176);
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
            this.buttonRemProd.Location = new System.Drawing.Point(177, 176);
            this.buttonRemProd.Name = "buttonRemProd";
            this.buttonRemProd.Size = new System.Drawing.Size(136, 45);
            this.buttonRemProd.TabIndex = 17;
            this.buttonRemProd.Text = "Remover Produto";
            this.buttonRemProd.UseVisualStyleBackColor = true;
            this.buttonRemProd.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 1049);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(119, 242);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 18;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(119, 286);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.buttonRemProd);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.buttonCancelarOp);
            this.Controls.Add(this.buttonRem);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkQuant);
            this.Controls.Add(this.checkBar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.buttonRmvF);
            this.Controls.Add(this.dataTabela);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.CheckBox checkBar;
        private System.Windows.Forms.CheckBox checkQuant;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRem;
        private System.Windows.Forms.Button buttonCancelarOp;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.Button buttonRemProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button button1;
    }
}