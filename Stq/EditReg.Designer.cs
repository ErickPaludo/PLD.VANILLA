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
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBoxEnvCodBars = new System.Windows.Forms.TextBox();
            this.textNewValue = new System.Windows.Forms.TextBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.textNewPeso = new System.Windows.Forms.TextBox();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(27, 283);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(139, 36);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEnvCodBars
            // 
            this.textBoxEnvCodBars.Location = new System.Drawing.Point(27, 40);
            this.textBoxEnvCodBars.MaxLength = 13;
            this.textBoxEnvCodBars.Name = "textBoxEnvCodBars";
            this.textBoxEnvCodBars.Size = new System.Drawing.Size(139, 20);
            this.textBoxEnvCodBars.TabIndex = 1;
            this.textBoxEnvCodBars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnvCodBars_KeyPress);
            // 
            // textNewValue
            // 
            this.textNewValue.Location = new System.Drawing.Point(27, 253);
            this.textNewValue.Name = "textNewValue";
            this.textNewValue.ShortcutsEnabled = false;
            this.textNewValue.Size = new System.Drawing.Size(139, 20);
            this.textNewValue.TabIndex = 5;
            this.textNewValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNewValue_KeyPress);
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
            this.comboColor.Location = new System.Drawing.Point(27, 146);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(139, 21);
            this.comboColor.TabIndex = 3;
            // 
            // textNewPeso
            // 
            this.textNewPeso.Location = new System.Drawing.Point(27, 200);
            this.textNewPeso.Name = "textNewPeso";
            this.textNewPeso.ShortcutsEnabled = false;
            this.textNewPeso.Size = new System.Drawing.Size(139, 20);
            this.textNewPeso.TabIndex = 4;
            this.textNewPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNewPeso_KeyPress);
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(27, 93);
            this.textProduto.MaxLength = 30;
            this.textProduto.Name = "textProduto";
            this.textProduto.ShortcutsEnabled = false;
            this.textProduto.Size = new System.Drawing.Size(139, 20);
            this.textProduto.TabIndex = 2;
            this.textProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código de Barras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peso (kg):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço:";
            // 
            // EditReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.textNewPeso);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.textNewValue);
            this.Controls.Add(this.textBoxEnvCodBars);
            this.Controls.Add(this.buttonAlterar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxEnvCodBars;
        private System.Windows.Forms.TextBox textNewValue;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.TextBox textNewPeso;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}