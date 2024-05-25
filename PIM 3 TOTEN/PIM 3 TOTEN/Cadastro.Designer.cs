namespace PIM_3_TOTEN
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lbl_nome = new Label();
            txb_NomeUsuario = new TextBox();
            btn_cadastrar = new Button();
            txb_Senha = new TextBox();
            lbl_senha = new Label();
            lbl_cadastro = new Label();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Segoe UI", 14.25F);
            lbl_nome.ForeColor = SystemColors.ButtonFace;
            lbl_nome.Location = new Point(153, 158);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(63, 25);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome";
            // 
            // txb_NomeUsuario
            // 
            txb_NomeUsuario.Font = new Font("Segoe UI", 14.25F);
            txb_NomeUsuario.Location = new Point(250, 158);
            txb_NomeUsuario.Name = "txb_NomeUsuario";
            txb_NomeUsuario.Size = new Size(371, 33);
            txb_NomeUsuario.TabIndex = 2;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.GradientInactiveCaption;
            btn_cadastrar.Location = new Point(475, 389);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(245, 100);
            btn_cadastrar.TabIndex = 3;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txb_Senha
            // 
            txb_Senha.Font = new Font("Segoe UI", 14.25F);
            txb_Senha.Location = new Point(250, 244);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.Size = new Size(371, 33);
            txb_Senha.TabIndex = 7;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Segoe UI", 14.25F);
            lbl_senha.ForeColor = SystemColors.ButtonFace;
            lbl_senha.Location = new Point(153, 244);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 25);
            lbl_senha.TabIndex = 6;
            lbl_senha.Text = "Senha";
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.BackColor = Color.Transparent;
            lbl_cadastro.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.ForeColor = SystemColors.ButtonFace;
            lbl_cadastro.Location = new Point(273, 37);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(327, 45);
            lbl_cadastro.TabIndex = 8;
            lbl_cadastro.Text = "Cadastro de usuario";
            lbl_cadastro.Click += lbl_cadastro_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientInactiveCaption;
            btn_voltar.Location = new Point(153, 389);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(245, 100);
            btn_voltar.TabIndex = 9;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(833, 513);
            Controls.Add(btn_voltar);
            Controls.Add(lbl_cadastro);
            Controls.Add(txb_Senha);
            Controls.Add(lbl_senha);
            Controls.Add(btn_cadastrar);
            Controls.Add(txb_NomeUsuario);
            Controls.Add(lbl_nome);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl_nome;
        public TextBox txb_NomeUsuario;
        public Button btn_cadastrar;
        public TextBox txb_Senha;
        public Label lbl_senha;
        public Label lbl_cadastro;
        public Button btn_voltar;
    }
}