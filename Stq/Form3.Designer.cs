﻿namespace Stq
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.textProd = new System.Windows.Forms.TextBox();
            this.textQuant = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPesoName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textProd
            // 
            this.textProd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textProd.ForeColor = System.Drawing.Color.White;
            this.textProd.Location = new System.Drawing.Point(54, 37);
            this.textProd.MaxLength = 30;
            this.textProd.Name = "textProd";
            this.textProd.ShortcutsEnabled = false;
            this.textProd.Size = new System.Drawing.Size(126, 20);
            this.textProd.TabIndex = 0;
            // 
            // textQuant
            // 
            this.textQuant.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuant.ForeColor = System.Drawing.Color.White;
            this.textQuant.Location = new System.Drawing.Point(54, 181);
            this.textQuant.Name = "textQuant";
            this.textQuant.ShortcutsEnabled = false;
            this.textQuant.Size = new System.Drawing.Size(126, 20);
            this.textQuant.TabIndex = 4;
            this.textQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQuant_KeyPress);
            // 
            // textPeso
            // 
            this.textPeso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPeso.ForeColor = System.Drawing.Color.White;
            this.textPeso.Location = new System.Drawing.Point(54, 133);
            this.textPeso.Name = "textPeso";
            this.textPeso.ShortcutsEnabled = false;
            this.textPeso.Size = new System.Drawing.Size(84, 20);
            this.textPeso.TabIndex = 2;
            this.textPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPeso_KeyPress);
            // 
            // textPreco
            // 
            this.textPreco.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPreco.ForeColor = System.Drawing.Color.White;
            this.textPreco.Location = new System.Drawing.Point(83, 229);
            this.textPreco.Name = "textPreco";
            this.textPreco.ShortcutsEnabled = false;
            this.textPreco.Size = new System.Drawing.Size(97, 20);
            this.textPreco.TabIndex = 5;
            this.textPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPreco_KeyPress);
            // 
            // comboColor
            // 
            this.comboColor.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            this.comboColor.Location = new System.Drawing.Point(54, 85);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(126, 21);
            this.comboColor.TabIndex = 1;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            this.comboColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboColor_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(54, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Peso:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "R$";
            // 
            // comboPesoName
            // 
            this.comboPesoName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesoName.FormattingEnabled = true;
            this.comboPesoName.Items.AddRange(new object[] {
            "Kg",
            "g",
            "L",
            "ml"});
            this.comboPesoName.Location = new System.Drawing.Point(144, 133);
            this.comboPesoName.Name = "comboPesoName";
            this.comboPesoName.Size = new System.Drawing.Size(36, 21);
            this.comboPesoName.TabIndex = 3;
            this.comboPesoName.SelectedIndexChanged += new System.EventHandler(this.comboPesoName_SelectedIndexChanged);
            this.comboPesoName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboPesoName_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(235, 361);
            this.Controls.Add(this.comboPesoName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textQuant);
            this.Controls.Add(this.textProd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProd;
        private System.Windows.Forms.TextBox textQuant;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPesoName;
    }
}