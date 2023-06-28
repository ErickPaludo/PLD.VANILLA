namespace Stq
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(265, 165);
            this.textUser.MaxLength = 3;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(171, 19);
            this.textUser.TabIndex = 0;
            this.textUser.Tag = "";
            this.textUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUser_KeyPress);
            // 
            // textPass
            // 
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(265, 243);
            this.textPass.MaxLength = 7;
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(171, 19);
            this.textPass.TabIndex = 1;
            this.textPass.UseSystemPasswordChar = true;
            this.textPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPass_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Image = global::Stq.Properties.Resources.buton_login;
            this.buttonLogin.Location = new System.Drawing.Point(314, 342);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 30);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.BackColor = System.Drawing.Color.Transparent;
            this.checkPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPass.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkPass.Location = new System.Drawing.Point(265, 285);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(83, 17);
            this.checkPass.TabIndex = 3;
            this.checkPass.Text = "Exibir senha";
            this.checkPass.UseVisualStyleBackColor = false;
            this.checkPass.Click += new System.EventHandler(this.checkPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(262, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(262, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stq.Properties.Resources.Background_login1;
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InVanilla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

