﻿namespace Stq
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
            this.textCamp1 = new System.Windows.Forms.TextBox();
            this.textEdit = new System.Windows.Forms.TextBox();
            this.comboBloq = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaUser)).BeginInit();
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
            this.dataTabelaUser.Location = new System.Drawing.Point(247, 12);
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
            this.dataTabelaUser.Size = new System.Drawing.Size(403, 285);
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
            this.buttonAdduser.Location = new System.Drawing.Point(12, 39);
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
            this.buttonRemuser.Location = new System.Drawing.Point(12, 78);
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
            this.buttonAlterarSenha.Location = new System.Drawing.Point(12, 117);
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
            this.comboTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoUser.ForeColor = System.Drawing.SystemColors.Window;
            this.comboTipoUser.FormattingEnabled = true;
            this.comboTipoUser.Items.AddRange(new object[] {
            "Padrão",
            "Admin"});
            this.comboTipoUser.Location = new System.Drawing.Point(183, 172);
            this.comboTipoUser.Name = "comboTipoUser";
            this.comboTipoUser.Size = new System.Drawing.Size(44, 21);
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
            this.buttonApc.Location = new System.Drawing.Point(64, 241);
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
            this.buttonCan.Location = new System.Drawing.Point(76, 280);
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
            this.textCamp2.ForeColor = System.Drawing.SystemColors.Window;
            this.textCamp2.Location = new System.Drawing.Point(46, 197);
            this.textCamp2.MaxLength = 8;
            this.textCamp2.Multiline = true;
            this.textCamp2.Name = "textCamp2";
            this.textCamp2.Size = new System.Drawing.Size(131, 21);
            this.textCamp2.TabIndex = 27;
            this.textCamp2.Visible = false;
            this.textCamp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCamp2_KeyPress);
            // 
            // textCamp1
            // 
            this.textCamp1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textCamp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCamp1.ForeColor = System.Drawing.SystemColors.Window;
            this.textCamp1.Location = new System.Drawing.Point(46, 172);
            this.textCamp1.Name = "textCamp1";
            this.textCamp1.Size = new System.Drawing.Size(131, 20);
            this.textCamp1.TabIndex = 28;
            this.textCamp1.Visible = false;
            // 
            // textEdit
            // 
            this.textEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.textEdit.Location = new System.Drawing.Point(46, 172);
            this.textEdit.MaxLength = 10;
            this.textEdit.Multiline = true;
            this.textEdit.Name = "textEdit";
            this.textEdit.Size = new System.Drawing.Size(131, 21);
            this.textEdit.TabIndex = 29;
            this.textEdit.Visible = false;
            this.textEdit.TextChanged += new System.EventHandler(this.textEdit_TextChanged);
            this.textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_KeyPress);
            this.textEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEdit_KeyUp);
            // 
            // comboBloq
            // 
            this.comboBloq.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBloq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBloq.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBloq.FormattingEnabled = true;
            this.comboBloq.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.comboBloq.Location = new System.Drawing.Point(183, 197);
            this.comboBloq.Name = "comboBloq";
            this.comboBloq.Size = new System.Drawing.Size(44, 21);
            this.comboBloq.TabIndex = 30;
            this.comboBloq.Visible = false;
            // 
            // buttonAplic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(662, 321);
            this.Controls.Add(this.comboBloq);
            this.Controls.Add(this.textEdit);
            this.Controls.Add(this.textCamp1);
            this.Controls.Add(this.textCamp2);
            this.Controls.Add(this.buttonCan);
            this.Controls.Add(this.buttonApc);
            this.Controls.Add(this.comboTipoUser);
            this.Controls.Add(this.buttonAlterarSenha);
            this.Controls.Add(this.buttonRemuser);
            this.Controls.Add(this.buttonAdduser);
            this.Controls.Add(this.dataTabelaUser);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTabelaUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button buttonAdduser;
        private System.Windows.Forms.Button buttonRemuser;
        private System.Windows.Forms.Button buttonAlterarSenha;
        private System.Windows.Forms.ComboBox comboTipoUser;
        private System.Windows.Forms.Button buttonApc;
        private System.Windows.Forms.Button buttonCan;
        private System.Windows.Forms.TextBox textCamp2;
        private System.Windows.Forms.TextBox textCamp1;
        private System.Windows.Forms.TextBox textEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocked;
        private System.Windows.Forms.ComboBox comboBloq;
    }
}