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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(523, 155);
            this.textUser.MaxLength = 10;
            this.textUser.Name = "textUser";
            this.textUser.ShortcutsEnabled = false;
            this.textUser.Size = new System.Drawing.Size(169, 19);
            this.textUser.TabIndex = 1;
            this.textUser.Tag = "";
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            this.textUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUser_KeyPress);
            this.textUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textUser_KeyUp);
            // 
            // textPass
            // 
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(523, 252);
            this.textPass.MaxLength = 8;
            this.textPass.Name = "textPass";
            this.textPass.ShortcutsEnabled = false;
            this.textPass.Size = new System.Drawing.Size(171, 19);
            this.textPass.TabIndex = 2;
            this.textPass.UseSystemPasswordChar = true;
            this.textPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPass_KeyPress);
            this.textPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPass_KeyUp);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = global::Stq.Properties.Resources.buton_login1;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogin.CausesValidation = false;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(553, 313);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(163, 73);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.BackColor = System.Drawing.Color.Transparent;
            this.checkPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPass.ForeColor = System.Drawing.Color.Cornsilk;
            this.checkPass.Location = new System.Drawing.Point(531, 290);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(83, 17);
            this.checkPass.TabIndex = 3;
            this.checkPass.Text = "Exibir senha";
            this.checkPass.UseVisualStyleBackColor = false;
            this.checkPass.Click += new System.EventHandler(this.checkPass_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Enabled = false;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.DimGray;
            this.labelUser.Location = new System.Drawing.Point(528, 156);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(60, 18);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Usuário";
            // 
            // labelPass
            // 
            this.labelPass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Enabled = false;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.DimGray;
            this.labelPass.Location = new System.Drawing.Point(528, 253);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(50, 18);
            this.labelPass.TabIndex = 6;
            this.labelPass.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stq.Properties.Resources.beckgroun_login;
            this.ClientSize = new System.Drawing.Size(896, 475);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonLogin;
    }
}

