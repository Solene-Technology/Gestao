namespace Gestao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            btnEstudantes = new Button();
            btnTurmas = new Button();
            btnCurso = new Button();
            btnListUser = new Button();
            btnRelatorios = new Button();
            button3 = new Button();
            btnDisciplina = new Button();
            btnPropinas = new Button();
            btnProfessores = new Button();
            pictureBox2 = new PictureBox();
            BarraDeTitulo = new Panel();
            iconrestaurar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconminimizar = new PictureBox();
            inconfechar = new PictureBox();
            BtnSuspender = new PictureBox();
            Conteudo = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inconfechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSuspender).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(192, 0, 0);
            MenuVertical.Controls.Add(btnEstudantes);
            MenuVertical.Controls.Add(btnTurmas);
            MenuVertical.Controls.Add(btnCurso);
            MenuVertical.Controls.Add(btnListUser);
            MenuVertical.Controls.Add(btnRelatorios);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(btnDisciplina);
            MenuVertical.Controls.Add(btnPropinas);
            MenuVertical.Controls.Add(btnProfessores);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            // 
            // btnEstudantes
            // 
            btnEstudantes.FlatAppearance.BorderSize = 0;
            btnEstudantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnEstudantes.FlatStyle = FlatStyle.Flat;
            btnEstudantes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEstudantes.ForeColor = Color.White;
            btnEstudantes.Image = (Image)resources.GetObject("btnEstudantes.Image");
            btnEstudantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstudantes.Location = new Point(3, 114);
            btnEstudantes.Name = "btnEstudantes";
            btnEstudantes.Size = new Size(247, 43);
            btnEstudantes.TabIndex = 10;
            btnEstudantes.Text = "Estudantes";
            btnEstudantes.UseVisualStyleBackColor = true;
            btnEstudantes.Click += btnEstudantes_Click;
            // 
            // btnTurmas
            // 
            btnTurmas.FlatAppearance.BorderSize = 0;
            btnTurmas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnTurmas.FlatStyle = FlatStyle.Flat;
            btnTurmas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTurmas.ForeColor = Color.White;
            btnTurmas.Image = Properties.Resources.student_card_icon_150965;
            btnTurmas.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurmas.Location = new Point(3, 189);
            btnTurmas.Name = "btnTurmas";
            btnTurmas.Size = new Size(250, 40);
            btnTurmas.TabIndex = 12;
            btnTurmas.Text = "Turmas";
            btnTurmas.UseVisualStyleBackColor = true;
            btnTurmas.Click += btnTurmas_Click;
            // 
            // btnCurso
            // 
            btnCurso.FlatAppearance.BorderSize = 0;
            btnCurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnCurso.FlatStyle = FlatStyle.Flat;
            btnCurso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCurso.ForeColor = Color.White;
            btnCurso.Image = Properties.Resources.courses;
            btnCurso.ImageAlign = ContentAlignment.MiddleLeft;
            btnCurso.Location = new Point(0, 153);
            btnCurso.Name = "btnCurso";
            btnCurso.Size = new Size(250, 40);
            btnCurso.TabIndex = 11;
            btnCurso.Text = "Cursos";
            btnCurso.UseVisualStyleBackColor = true;
            btnCurso.Click += btnCurso_Click;
            // 
            // btnListUser
            // 
            btnListUser.FlatAppearance.BorderSize = 0;
            btnListUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnListUser.FlatStyle = FlatStyle.Flat;
            btnListUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnListUser.ForeColor = Color.White;
            btnListUser.Image = (Image)resources.GetObject("btnListUser.Image");
            btnListUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnListUser.Location = new Point(0, 419);
            btnListUser.Name = "btnListUser";
            btnListUser.Size = new Size(250, 40);
            btnListUser.TabIndex = 6;
            btnListUser.Text = "Usuarios";
            btnListUser.UseVisualStyleBackColor = true;
            btnListUser.Click += btnListUser_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Image = (Image)resources.GetObject("btnRelatorios.Image");
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(0, 373);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(247, 40);
            btnRelatorios.TabIndex = 5;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 610);
            button3.Name = "button3";
            button3.Size = new Size(250, 40);
            button3.TabIndex = 3;
            button3.Text = "Terminar Sessão";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnDisciplina
            // 
            btnDisciplina.FlatAppearance.BorderSize = 0;
            btnDisciplina.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnDisciplina.FlatStyle = FlatStyle.Flat;
            btnDisciplina.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDisciplina.ForeColor = Color.White;
            btnDisciplina.Image = (Image)resources.GetObject("btnDisciplina.Image");
            btnDisciplina.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisciplina.Location = new Point(0, 327);
            btnDisciplina.Name = "btnDisciplina";
            btnDisciplina.Size = new Size(247, 40);
            btnDisciplina.TabIndex = 9;
            btnDisciplina.Text = "Disciplinas";
            btnDisciplina.UseVisualStyleBackColor = true;
            btnDisciplina.Click += btnDisciplina_Click;
            // 
            // btnPropinas
            // 
            btnPropinas.FlatAppearance.BorderSize = 0;
            btnPropinas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnPropinas.FlatStyle = FlatStyle.Flat;
            btnPropinas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPropinas.ForeColor = Color.White;
            btnPropinas.Image = (Image)resources.GetObject("btnPropinas.Image");
            btnPropinas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPropinas.Location = new Point(0, 281);
            btnPropinas.Name = "btnPropinas";
            btnPropinas.Size = new Size(250, 40);
            btnPropinas.TabIndex = 8;
            btnPropinas.Text = "Propinas";
            btnPropinas.UseVisualStyleBackColor = true;
            btnPropinas.Click += btnPropinas_Click;
            // 
            // btnProfessores
            // 
            btnProfessores.FlatAppearance.BorderSize = 0;
            btnProfessores.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 38);
            btnProfessores.FlatStyle = FlatStyle.Flat;
            btnProfessores.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProfessores.ForeColor = Color.White;
            btnProfessores.Image = (Image)resources.GetObject("btnProfessores.Image");
            btnProfessores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfessores.Location = new Point(0, 235);
            btnProfessores.Name = "btnProfessores";
            btnProfessores.Size = new Size(250, 40);
            btnProfessores.TabIndex = 2;
            btnProfessores.Text = "Professores";
            btnProfessores.UseVisualStyleBackColor = true;
            btnProfessores.Click += btnProfessores_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_13_01_2026__11_55_51;
            pictureBox2.Location = new Point(3, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BarraDeTitulo
            // 
            BarraDeTitulo.Controls.Add(iconrestaurar);
            BarraDeTitulo.Controls.Add(iconmaximizar);
            BarraDeTitulo.Controls.Add(iconminimizar);
            BarraDeTitulo.Controls.Add(inconfechar);
            BarraDeTitulo.Controls.Add(BtnSuspender);
            BarraDeTitulo.Dock = DockStyle.Top;
            BarraDeTitulo.Location = new Point(250, 0);
            BarraDeTitulo.Name = "BarraDeTitulo";
            BarraDeTitulo.Size = new Size(1050, 50);
            BarraDeTitulo.TabIndex = 1;
            BarraDeTitulo.MouseDown += BarraDeTitulo_MouseDown;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Image = Properties.Resources.maximize;
            iconrestaurar.Location = new Point(996, 9);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(20, 20);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 4;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.Image = Properties.Resources.maximize;
            iconmaximizar.Location = new Point(996, 9);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(20, 20);
            iconmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 3;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += pictureBox4_Click;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Image = Properties.Resources.minimize;
            iconminimizar.Location = new Point(970, 9);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(20, 20);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 2;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // inconfechar
            // 
            inconfechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inconfechar.Image = Properties.Resources.fechar;
            inconfechar.Location = new Point(1022, 9);
            inconfechar.Name = "inconfechar";
            inconfechar.Size = new Size(20, 20);
            inconfechar.SizeMode = PictureBoxSizeMode.Zoom;
            inconfechar.TabIndex = 1;
            inconfechar.TabStop = false;
            inconfechar.Click += pictureBox1_Click;
            // 
            // BtnSuspender
            // 
            BtnSuspender.Cursor = Cursors.Hand;
            BtnSuspender.Image = Properties.Resources.menu;
            BtnSuspender.Location = new Point(6, 9);
            BtnSuspender.Name = "BtnSuspender";
            BtnSuspender.Size = new Size(35, 35);
            BtnSuspender.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSuspender.TabIndex = 0;
            BtnSuspender.TabStop = false;
            BtnSuspender.Click += BtnSuspender_Click;
            // 
            // Conteudo
            // 
            Conteudo.Dock = DockStyle.Fill;
            Conteudo.Location = new Point(250, 50);
            Conteudo.Name = "Conteudo";
            Conteudo.Size = new Size(1050, 600);
            Conteudo.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(Conteudo);
            Controls.Add(BarraDeTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraDeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)inconfechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSuspender).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraDeTitulo;
        private Panel Conteudo;
        private PictureBox BtnSuspender;
        private PictureBox pictureBox2;
        private PictureBox inconfechar;
        private PictureBox iconmaximizar;
        private PictureBox iconminimizar;
        private PictureBox iconrestaurar;
        private Button btnCurso;
        private Button btnEstudantes;
        private Button btnDisciplina;
        private Button btnPropinas;
        private Button btnListUser;
        private Button btnRelatorios;
        private Button button3;
        private Button btnProfessores;
        private Button btnTurmas;
    }
}
