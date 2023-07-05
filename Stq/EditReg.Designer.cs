namespace Stq
{
    partial class EditReg
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEnvCodBars = new System.Windows.Forms.TextBox();
            this.textNewValue = new System.Windows.Forms.TextBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.textNewPeso = new System.Windows.Forms.TextBox();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEnvCodBars
            // 
            this.textBoxEnvCodBars.Location = new System.Drawing.Point(25, 12);
            this.textBoxEnvCodBars.Name = "textBoxEnvCodBars";
            this.textBoxEnvCodBars.Size = new System.Drawing.Size(139, 20);
            this.textBoxEnvCodBars.TabIndex = 1;
            this.textBoxEnvCodBars.Text = "cod";
            // 
            // textNewValue
            // 
            this.textNewValue.Location = new System.Drawing.Point(25, 157);
            this.textNewValue.Name = "textNewValue";
            this.textNewValue.Size = new System.Drawing.Size(139, 20);
            this.textNewValue.TabIndex = 3;
            this.textNewValue.Text = "Valor";
            // 
            // comboColor
            // 
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            "Azul",
            "Vermelho",
            "Amarelo",
            "Verde",
            "Branco",
            "Cinza",
            "Preto",
            "Roxo",
            "Marrom",
            "Laranja",
            "(Não informado)",
            "Outros"});
            this.comboColor.Location = new System.Drawing.Point(25, 75);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(139, 21);
            this.comboColor.TabIndex = 4;
            // 
            // textNewPeso
            // 
            this.textNewPeso.Location = new System.Drawing.Point(25, 117);
            this.textNewPeso.Name = "textNewPeso";
            this.textNewPeso.Size = new System.Drawing.Size(139, 20);
            this.textNewPeso.TabIndex = 5;
            this.textNewPeso.Text = "Peso";
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(25, 38);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(139, 20);
            this.textProduto.TabIndex = 6;
            this.textProduto.Text = "Nome";
            // 
            // EditReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 257);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.textNewPeso);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.textNewValue);
            this.Controls.Add(this.textBoxEnvCodBars);
            this.Controls.Add(this.button1);
            this.Name = "EditReg";
            this.Text = "EditReg";
            this.Load += new System.EventHandler(this.EditReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEnvCodBars;
        private System.Windows.Forms.TextBox textNewValue;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.TextBox textNewPeso;
        private System.Windows.Forms.TextBox textProduto;
    }
}