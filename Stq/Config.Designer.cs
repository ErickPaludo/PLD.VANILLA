﻿namespace Stq
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.buttonAplic = new System.Windows.Forms.Button();
            this.labellim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque mínimo:";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(79, 65);
            this.textValue.MaxLength = 4;
            this.textValue.Name = "textValue";
            this.textValue.ShortcutsEnabled = false;
            this.textValue.Size = new System.Drawing.Size(133, 20);
            this.textValue.TabIndex = 1;
            this.textValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textValue_KeyPress);
            // 
            // buttonAplic
            // 
            this.buttonAplic.Location = new System.Drawing.Point(79, 108);
            this.buttonAplic.Name = "buttonAplic";
            this.buttonAplic.Size = new System.Drawing.Size(133, 29);
            this.buttonAplic.TabIndex = 2;
            this.buttonAplic.Text = "Aplicar";
            this.buttonAplic.UseVisualStyleBackColor = true;
            this.buttonAplic.Click += new System.EventHandler(this.buttonAplic_Click);
            // 
            // labellim
            // 
            this.labellim.AutoSize = true;
            this.labellim.Location = new System.Drawing.Point(79, 13);
            this.labellim.Name = "labellim";
            this.labellim.Size = new System.Drawing.Size(83, 13);
            this.labellim.TabIndex = 3;
            this.labellim.Text = "LIMITE ATUAL:";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 170);
            this.Controls.Add(this.labellim);
            this.Controls.Add(this.buttonAplic);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button buttonAplic;
        private System.Windows.Forms.Label labellim;
    }
}