namespace Gestao.Views
{
    partial class LoginFrm
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
            panel1 = new Panel();
            loginBtn = new Button();
            label2 = new Label();
            panel3 = new Panel();
            txtSenha = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(300, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 394);
            panel1.TabIndex = 0;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Red;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.Location = new Point(60, 297);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(243, 38);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Entrar";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 221);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Palavra Pass";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSenha);
            panel3.Location = new Point(60, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 28);
            panel3.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(3, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(237, 23);
            txtSenha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 153);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(57, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 28);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(237, 23);
            txtUsername.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_13_01_2026__11_55_511;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFrm";
            Load += LoginFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox txtSenha;
        private Label label2;
        private Panel panel3;
        private TextBox txtUsername;
        private Button loginBtn;
    }
}