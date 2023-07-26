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
            this.textNewValue = new System.Windows.Forms.TextBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.textNewPeso = new System.Windows.Forms.TextBox();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPesoN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.DimGray;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.White;
            this.buttonAlterar.Location = new System.Drawing.Point(26, 240);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(139, 36);
            this.buttonAlterar.TabIndex = 5;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNewValue
            // 
            this.textNewValue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textNewValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNewValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textNewValue.ForeColor = System.Drawing.SystemColors.Window;
            this.textNewValue.Location = new System.Drawing.Point(26, 210);
            this.textNewValue.Name = "textNewValue";
            this.textNewValue.ShortcutsEnabled = false;
            this.textNewValue.Size = new System.Drawing.Size(139, 20);
            this.textNewValue.TabIndex = 4;
            this.textNewValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNewValue_KeyPress);
            // 
            // comboColor
            // 
            this.comboColor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboColor.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            "       ",
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
            "Outros"});
            this.comboColor.Location = new System.Drawing.Point(26, 103);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(139, 21);
            this.comboColor.TabIndex = 2;
            // 
            // textNewPeso
            // 
            this.textNewPeso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textNewPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNewPeso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textNewPeso.ForeColor = System.Drawing.SystemColors.Window;
            this.textNewPeso.Location = new System.Drawing.Point(26, 156);
            this.textNewPeso.Name = "textNewPeso";
            this.textNewPeso.ShortcutsEnabled = false;
            this.textNewPeso.Size = new System.Drawing.Size(96, 20);
            this.textNewPeso.TabIndex = 3;
            this.textNewPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNewPeso_KeyPress);
            // 
            // textProduto
            // 
            this.textProduto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.textProduto.Location = new System.Drawing.Point(26, 50);
            this.textProduto.MaxLength = 30;
            this.textProduto.Name = "textProduto";
            this.textProduto.ShortcutsEnabled = false;
            this.textProduto.Size = new System.Drawing.Size(139, 20);
            this.textProduto.TabIndex = 1;
            this.textProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peso (kg):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço:";
            // 
            // comboPesoN
            // 
            this.comboPesoN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboPesoN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesoN.FormattingEnabled = true;
            this.comboPesoN.Items.AddRange(new object[] {
            "Kg",
            "g",
            "L",
            "ml"});
            this.comboPesoN.Location = new System.Drawing.Point(128, 155);
            this.comboPesoN.Name = "comboPesoN";
            this.comboPesoN.Size = new System.Drawing.Size(37, 21);
            this.comboPesoN.TabIndex = 12;
            this.comboPesoN.SelectedIndexChanged += new System.EventHandler(this.comboPesoN_SelectedIndexChanged);
            // 
            // EditReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(191, 298);
            this.Controls.Add(this.comboPesoN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.textNewPeso);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.textNewValue);
            this.Controls.Add(this.buttonAlterar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
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
        private System.Windows.Forms.TextBox textNewValue;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.TextBox textNewPeso;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPesoN;
    }
}