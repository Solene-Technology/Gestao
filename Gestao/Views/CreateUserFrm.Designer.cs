namespace Gestao.Views
{
    partial class CreateUserFrm
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
            txtUsername = new TextBox();
            txtSenha = new TextBox();
            txtSenha2 = new TextBox();
            txtNome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtPerfil = new ComboBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(310, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(310, 210);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(221, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtSenha2
            // 
            txtSenha2.Location = new Point(310, 270);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(221, 23);
            txtSenha2.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(310, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 23);
            txtNome.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(310, 315);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(456, 315);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtPerfil
            // 
            txtPerfil.FormattingEnabled = true;
            txtPerfil.Items.AddRange(new object[] { "Admin", "Professor", "Secretario" });
            txtPerfil.Location = new Point(375, 243);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(121, 23);
            txtPerfil.TabIndex = 6;
            // 
            // CreateUserFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPerfil);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(txtSenha2);
            Controls.Add(txtSenha);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateUserFrm";
            Text = "CreateUserFrm";
            Load += CreateUserFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtSenha;
        private TextBox txtSenha2;
        private TextBox txtNome;
        private Button button1;
        private Button button2;
        private ComboBox txtPerfil;
    }
}