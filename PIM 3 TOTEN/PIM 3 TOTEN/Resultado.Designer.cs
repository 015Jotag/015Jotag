namespace PIM_3_TOTEN
{
    partial class Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado));
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            Btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 60F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 228);
            label1.Name = "label1";
            label1.Size = new Size(364, 97);
            label1.TabIndex = 0;
            label1.Text = "Respostas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(53, 485);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(53, 29);
            label8.Name = "label8";
            label8.Size = new Size(167, 54);
            label8.TabIndex = 7;
            label8.Text = "Usuario";
            // 
            // Btn_voltar
            // 
            Btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            Btn_voltar.Font = new Font("Segoe UI", 18F);
            Btn_voltar.Location = new Point(42, 474);
            Btn_voltar.Name = "Btn_voltar";
            Btn_voltar.Size = new Size(234, 80);
            Btn_voltar.TabIndex = 33;
            Btn_voltar.Text = "Voltar";
            Btn_voltar.UseVisualStyleBackColor = false;
            Btn_voltar.Click += Btn_voltar_Click;
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1334, 621);
            Controls.Add(Btn_voltar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "Resultado";
            Text = "Resultado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Label label8;
        private Button Btn_voltar;
    }
}