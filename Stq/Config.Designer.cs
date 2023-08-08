namespace Stq
{
    partial class buttonAplic
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
            this.dataTabelaUser = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdduser = new System.Windows.Forms.Button();
            this.buttonRemuser = new System.Windows.Forms.Button();
            this.buttonAlterarSenha = new System.Windows.Forms.Button();
            this.comboTipoUser = new System.Windows.Forms.ComboBox();
            this.buttonApc = new System.Windows.Forms.Button();
            this.buttonCan = new System.Windows.Forms.Button();
            this.textCamp2 = new System.Windows.Forms.TextBox();
            this.comboBloq = new System.Windows.Forms.ComboBox();
            this.textCamp1 = new System.Windows.Forms.TextBox();
            this.textEdit = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTabelaUser
            // 
            this.dataTabelaUser.AllowUserToAddRows = false;
            this.dataTabelaUser.AllowUserToDeleteRows = false;
            this.dataTabelaUser.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            this.dataTabelaUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTabelaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTabelaUser.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataTabelaUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTabelaUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTabelaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Pass,
            this.tipo,
            this.Blocked});
            this.dataTabelaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTabelaUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTabelaUser.EnableHeadersVisualStyles = false;
            this.dataTabelaUser.GridColor = System.Drawing.Color.DimGray;
            this.dataTabelaUser.Location = new System.Drawing.Point(19, 12);
            this.dataTabelaUser.Name = "dataTabelaUser";
            this.dataTabelaUser.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTabelaUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTabelaUser.RowHeadersVisible = false;
            this.dataTabelaUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTabelaUser.Size = new System.Drawing.Size(352, 130);
            this.dataTabelaUser.TabIndex = 18;
            // 
            // User
            // 
            this.User.HeaderText = "Usuário";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Senha";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // Blocked
            // 
            this.Blocked.HeaderText = "Bloqueados";
            this.Blocked.Name = "Blocked";
            this.Blocked.ReadOnly = true;
            // 
            // buttonAdduser
            // 
            this.buttonAdduser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdduser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdduser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdduser.Location = new System.Drawing.Point(19, 148);
            this.buttonAdduser.Name = "buttonAdduser";
            this.buttonAdduser.Size = new System.Drawing.Size(215, 33);
            this.buttonAdduser.TabIndex = 19;
            this.buttonAdduser.Text = "Adicionar Usuário";
            this.buttonAdduser.UseVisualStyleBackColor = false;
            this.buttonAdduser.Click += new System.EventHandler(this.buttonAdduser_Click);
            // 
            // buttonRemuser
            // 
            this.buttonRemuser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRemuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemuser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemuser.Location = new System.Drawing.Point(19, 187);
            this.buttonRemuser.Name = "buttonRemuser";
            this.buttonRemuser.Size = new System.Drawing.Size(215, 33);
            this.buttonRemuser.TabIndex = 20;
            this.buttonRemuser.Text = "Remover Usuário";
            this.buttonRemuser.UseVisualStyleBackColor = false;
            this.buttonRemuser.Click += new System.EventHandler(this.buttonRemuser_Click);
            // 
            // buttonAlterarSenha
            // 
            this.buttonAlterarSenha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAlterarSenha.Location = new System.Drawing.Point(19, 226);
            this.buttonAlterarSenha.Name = "buttonAlterarSenha";
            this.buttonAlterarSenha.Size = new System.Drawing.Size(215, 33);
            this.buttonAlterarSenha.TabIndex = 21;
            this.buttonAlterarSenha.Text = "Confg User";
            this.buttonAlterarSenha.UseVisualStyleBackColor = false;
            this.buttonAlterarSenha.Click += new System.EventHandler(this.buttonAlterarSenha_Click);
            // 
            // comboTipoUser
            // 
            this.comboTipoUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboTipoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoUser.ForeColor = System.Drawing.SystemColors.Window;
            this.comboTipoUser.FormattingEnabled = true;
            this.comboTipoUser.Items.AddRange(new object[] {
            "Padrão",
            "Admin"});
            this.comboTipoUser.Location = new System.Drawing.Point(240, 289);
            this.comboTipoUser.Name = "comboTipoUser";
            this.comboTipoUser.Size = new System.Drawing.Size(72, 21);
            this.comboTipoUser.TabIndex = 24;
            this.comboTipoUser.Visible = false;
            // 
            // buttonApc
            // 
            this.buttonApc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonApc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonApc.Location = new System.Drawing.Point(75, 265);
            this.buttonApc.Name = "buttonApc";
            this.buttonApc.Size = new System.Drawing.Size(99, 33);
            this.buttonApc.TabIndex = 25;
            this.buttonApc.Text = "Aplicar";
            this.buttonApc.UseVisualStyleBackColor = false;
            this.buttonApc.Visible = false;
            this.buttonApc.Click += new System.EventHandler(this.buttonApc_Click);
            // 
            // buttonCan
            // 
            this.buttonCan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCan.Location = new System.Drawing.Point(90, 300);
            this.buttonCan.Name = "buttonCan";
            this.buttonCan.Size = new System.Drawing.Size(72, 23);
            this.buttonCan.TabIndex = 26;
            this.buttonCan.Text = "Cancelar";
            this.buttonCan.UseVisualStyleBackColor = false;
            this.buttonCan.Visible = false;
            this.buttonCan.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCamp2
            // 
            this.textCamp2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textCamp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCamp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textCamp2.ForeColor = System.Drawing.SystemColors.Window;
            this.textCamp2.Location = new System.Drawing.Point(240, 238);
            this.textCamp2.MaxLength = 8;
            this.textCamp2.Multiline = true;
            this.textCamp2.Name = "textCamp2";
            this.textCamp2.Size = new System.Drawing.Size(131, 21);
            this.textCamp2.TabIndex = 27;
            this.textCamp2.Visible = false;
            this.textCamp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCamp2_KeyPress);
            // 
            // comboBloq
            // 
            this.comboBloq.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBloq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBloq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBloq.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBloq.FormattingEnabled = true;
            this.comboBloq.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.comboBloq.Location = new System.Drawing.Point(318, 289);
            this.comboBloq.Name = "comboBloq";
            this.comboBloq.Size = new System.Drawing.Size(57, 21);
            this.comboBloq.TabIndex = 30;
            this.comboBloq.Visible = false;
            // 
            // textCamp1
            // 
            this.textCamp1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textCamp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCamp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textCamp1.ForeColor = System.Drawing.SystemColors.Window;
            this.textCamp1.Location = new System.Drawing.Point(240, 161);
            this.textCamp1.MaxLength = 10;
            this.textCamp1.Name = "textCamp1";
            this.textCamp1.Size = new System.Drawing.Size(131, 20);
            this.textCamp1.TabIndex = 28;
            this.textCamp1.Visible = false;
            this.textCamp1.TextChanged += new System.EventHandler(this.textCamp1_TextChanged);
            this.textCamp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCamp1_KeyPress);
            this.textCamp1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCamp1_KeyUp);
            // 
            // textEdit
            // 
            this.textEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.textEdit.Location = new System.Drawing.Point(240, 200);
            this.textEdit.MaxLength = 10;
            this.textEdit.Name = "textEdit";
            this.textEdit.Size = new System.Drawing.Size(131, 20);
            this.textEdit.TabIndex = 31;
            this.textEdit.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(237, 145);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Nome:";
            this.labelName.Visible = false;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSenha.Location = new System.Drawing.Point(237, 222);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 33;
            this.labelSenha.Text = "Senha:";
            this.labelSenha.Visible = false;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNewName.Location = new System.Drawing.Point(237, 184);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(67, 13);
            this.labelNewName.TabIndex = 34;
            this.labelNewName.Text = "Novo Nome:";
            this.labelNewName.Visible = false;
            this.labelNewName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelP.Location = new System.Drawing.Point(237, 273);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(53, 13);
            this.labelP.TabIndex = 35;
            this.labelP.Text = "Permisão:";
            this.labelP.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelB.Location = new System.Drawing.Point(315, 273);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(61, 13);
            this.labelB.TabIndex = 36;
            this.labelB.Text = "Bloqueado:";
            this.labelB.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Stq.Properties.Resources.pngtree_vector_house_icon_png_image_695726;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(13, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonAplic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(385, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textEdit);
            this.Controls.Add(this.comboBloq);
            this.Controls.Add(this.textCamp1);
            this.Controls.Add(this.textCamp2);
            this.Controls.Add(this.buttonCan);
            this.Controls.Add(this.buttonApc);
            this.Controls.Add(this.comboTipoUser);
            this.Controls.Add(this.buttonAlterarSenha);
            this.Controls.Add(this.buttonRemuser);
            this.Controls.Add(this.buttonAdduser);
            this.Controls.Add(this.dataTabelaUser);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "buttonAplic";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTabelaUser;
        private System.Windows.Forms.Button buttonAdduser;
        private System.Windows.Forms.Button buttonRemuser;
        private System.Windows.Forms.Button buttonAlterarSenha;
        private System.Windows.Forms.ComboBox comboTipoUser;
        private System.Windows.Forms.Button buttonApc;
        private System.Windows.Forms.Button buttonCan;
        private System.Windows.Forms.TextBox textCamp2;
        private System.Windows.Forms.ComboBox comboBloq;
        private System.Windows.Forms.TextBox textCamp1;
        private System.Windows.Forms.TextBox textEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocked;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}