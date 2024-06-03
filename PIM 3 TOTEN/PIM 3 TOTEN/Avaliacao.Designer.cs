﻿using System.Diagnostics;

namespace PIM_3_TOTEN.Properties
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class Avaliacao
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avaliacao));
            lblTitulo = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Btn_Avaliar = new Button();
            RbSim = new RadioButton();
            RbNao = new RadioButton();
            RbSim2 = new RadioButton();
            RbNao2 = new RadioButton();
            RbSim3 = new RadioButton();
            RbNao3 = new RadioButton();
            RbSim4 = new RadioButton();
            RbNao4 = new RadioButton();
            RbSim5 = new RadioButton();
            RbNao5 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(615, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 18F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(467, 42);
            label2.Name = "label2";
            label2.Size = new Size(370, 29);
            label2.TabIndex = 1;
            label2.Text = "Avalie a obra com uma nota de 1 a 5";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Calibri", 14.25F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(543, 74);
            button1.Name = "button1";
            button1.Size = new Size(42, 54);
            button1.TabIndex = 2;
            button1.Tag = "Avaliação";
            button1.Text = "1";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Calibri", 14.25F);
            button2.Location = new Point(735, 74);
            button2.Name = "button2";
            button2.Size = new Size(42, 54);
            button2.TabIndex = 3;
            button2.Tag = "Avaliação";
            button2.Text = "5";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("Calibri", 14.25F);
            button3.Location = new Point(687, 74);
            button3.Name = "button3";
            button3.Size = new Size(42, 54);
            button3.TabIndex = 4;
            button3.Tag = "Avaliação";
            button3.Text = "4";
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Calibri", 14.25F);
            button4.Location = new Point(639, 74);
            button4.Name = "button4";
            button4.Size = new Size(42, 54);
            button4.TabIndex = 5;
            button4.Tag = "Avaliação";
            button4.Text = "3";
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Font = new Font("Calibri", 14.25F);
            button5.Location = new Point(591, 74);
            button5.Name = "button5";
            button5.Size = new Size(42, 54);
            button5.TabIndex = 6;
            button5.Tag = "Avaliação";
            button5.Text = "2";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(347, 197);
            label3.Name = "label3";
            label3.Size = new Size(583, 32);
            label3.TabIndex = 7;
            label3.Text = "1-A obra desperta uma resposta emocional em você?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(361, 131);
            label4.Name = "label4";
            label4.Size = new Size(186, 38);
            label4.TabIndex = 9;
            label4.Text = "Questionario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(361, 165);
            label5.Name = "label5";
            label5.Size = new Size(244, 32);
            label5.TabIndex = 10;
            label5.Text = "Responda sim ou não";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(347, 289);
            label6.Name = "label6";
            label6.Size = new Size(489, 32);
            label6.TabIndex = 11;
            label6.Text = "2-A composição da obra parece equilibrada?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(347, 368);
            label7.Name = "label7";
            label7.Size = new Size(699, 32);
            label7.TabIndex = 13;
            label7.Text = "3-Os elementos principais da obra são facilmente identificáveis?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(347, 441);
            label8.Name = "label8";
            label8.Size = new Size(769, 32);
            label8.TabIndex = 15;
            label8.Text = "4-As referencias na obra tras a lembrança o sentimento do momento ?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 18F);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(347, 523);
            label9.Name = "label9";
            label9.Size = new Size(517, 32);
            label9.TabIndex = 17;
            label9.Text = "5-A obra parece bem executada tecnicamente?";
            // 
            // Btn_Avaliar
            // 
            Btn_Avaliar.BackColor = SystemColors.GradientActiveCaption;
            Btn_Avaliar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Avaliar.Location = new Point(1170, 545);
            Btn_Avaliar.Name = "Btn_Avaliar";
            Btn_Avaliar.Size = new Size(152, 64);
            Btn_Avaliar.TabIndex = 19;
            Btn_Avaliar.Text = "Avaliar";
            Btn_Avaliar.UseCompatibleTextRendering = true;
            Btn_Avaliar.UseVisualStyleBackColor = false;
            Btn_Avaliar.Click += Btn_Avaliar_Click;
            // 
            // RbSim
            // 
            RbSim.AutoSize = true;
            RbSim.BackColor = Color.Transparent;
            RbSim.Font = new Font("Segoe UI", 12F);
            RbSim.ForeColor = Color.WhiteSmoke;
            RbSim.Location = new Point(6, 11);
            RbSim.Name = "RbSim";
            RbSim.Size = new Size(55, 25);
            RbSim.TabIndex = 20;
            RbSim.TabStop = true;
            RbSim.Tag = "Pergunta 1";
            RbSim.Text = "Sim";
            RbSim.UseVisualStyleBackColor = false;
            RbSim.CheckedChanged += RbSim_CheckedChanged;
            // 
            // RbNao
            // 
            RbNao.AutoSize = true;
            RbNao.BackColor = Color.Transparent;
            RbNao.Font = new Font("Segoe UI", 12F);
            RbNao.ForeColor = SystemColors.ButtonHighlight;
            RbNao.Location = new Point(6, 29);
            RbNao.Name = "RbNao";
            RbNao.Size = new Size(57, 25);
            RbNao.TabIndex = 21;
            RbNao.TabStop = true;
            RbNao.Tag = "Pergunta 1";
            RbNao.Text = "Não";
            RbNao.UseVisualStyleBackColor = false;
            RbNao.CheckedChanged += RbNao_CheckedChanged;
            // 
            // RbSim2
            // 
            RbSim2.AutoSize = true;
            RbSim2.BackColor = Color.Transparent;
            RbSim2.Font = new Font("Segoe UI", 12F);
            RbSim2.ForeColor = SystemColors.ButtonHighlight;
            RbSim2.Location = new Point(6, 11);
            RbSim2.Name = "RbSim2";
            RbSim2.Size = new Size(55, 25);
            RbSim2.TabIndex = 22;
            RbSim2.TabStop = true;
            RbSim2.Tag = "Pergunta 2";
            RbSim2.Text = "Sim";
            RbSim2.UseVisualStyleBackColor = false;
            RbSim2.CheckedChanged += RbSim2_CheckedChanged;
            // 
            // RbNao2
            // 
            RbNao2.AutoSize = true;
            RbNao2.BackColor = Color.Transparent;
            RbNao2.Font = new Font("Segoe UI", 12F);
            RbNao2.ForeColor = SystemColors.ButtonHighlight;
            RbNao2.Location = new Point(6, 29);
            RbNao2.Name = "RbNao2";
            RbNao2.Size = new Size(57, 25);
            RbNao2.TabIndex = 23;
            RbNao2.TabStop = true;
            RbNao2.Tag = "Pergunta 2";
            RbNao2.Text = "Não";
            RbNao2.UseVisualStyleBackColor = false;
            RbNao2.CheckedChanged += RbNao2_CheckedChanged;
            // 
            // RbSim3
            // 
            RbSim3.AutoSize = true;
            RbSim3.BackColor = Color.Transparent;
            RbSim3.Font = new Font("Segoe UI", 12F);
            RbSim3.ForeColor = SystemColors.ButtonHighlight;
            RbSim3.Location = new Point(6, 11);
            RbSim3.Name = "RbSim3";
            RbSim3.Size = new Size(55, 25);
            RbSim3.TabIndex = 24;
            RbSim3.TabStop = true;
            RbSim3.Tag = "Pergunta 3";
            RbSim3.Text = "Sim";
            RbSim3.UseVisualStyleBackColor = false;
            RbSim3.CheckedChanged += RbSim3_CheckedChanged;
            // 
            // RbNao3
            // 
            RbNao3.AutoSize = true;
            RbNao3.BackColor = Color.Transparent;
            RbNao3.Font = new Font("Segoe UI", 12F);
            RbNao3.ForeColor = SystemColors.ButtonHighlight;
            RbNao3.Location = new Point(6, 29);
            RbNao3.Name = "RbNao3";
            RbNao3.Size = new Size(57, 25);
            RbNao3.TabIndex = 25;
            RbNao3.TabStop = true;
            RbNao3.Tag = "Pergunta 3";
            RbNao3.Text = "Não";
            RbNao3.UseVisualStyleBackColor = false;
            RbNao3.CheckedChanged += RbNao3_CheckedChanged;
            // 
            // RbSim4
            // 
            RbSim4.AutoSize = true;
            RbSim4.BackColor = Color.Transparent;
            RbSim4.Font = new Font("Segoe UI", 12F);
            RbSim4.ForeColor = SystemColors.ButtonHighlight;
            RbSim4.Location = new Point(6, 9);
            RbSim4.Name = "RbSim4";
            RbSim4.Size = new Size(55, 25);
            RbSim4.TabIndex = 30;
            RbSim4.TabStop = true;
            RbSim4.Tag = "Pergunta 4";
            RbSim4.Text = "Sim";
            RbSim4.UseVisualStyleBackColor = false;
            RbSim4.CheckedChanged += RbSim4_CheckedChanged;
            // 
            // RbNao4
            // 
            RbNao4.AutoSize = true;
            RbNao4.BackColor = Color.Transparent;
            RbNao4.Font = new Font("Segoe UI", 12F);
            RbNao4.ForeColor = SystemColors.ControlLightLight;
            RbNao4.Location = new Point(6, 29);
            RbNao4.Name = "RbNao4";
            RbNao4.Size = new Size(57, 25);
            RbNao4.TabIndex = 31;
            RbNao4.TabStop = true;
            RbNao4.Tag = "Pergunta 4";
            RbNao4.Text = "Não";
            RbNao4.UseVisualStyleBackColor = false;
            RbNao4.CheckedChanged += RbNao4_CheckedChanged;
            // 
            // RbSim5
            // 
            RbSim5.AutoSize = true;
            RbSim5.BackColor = Color.Transparent;
            RbSim5.Font = new Font("Segoe UI", 12F);
            RbSim5.ForeColor = SystemColors.ButtonHighlight;
            RbSim5.Location = new Point(8, 11);
            RbSim5.Name = "RbSim5";
            RbSim5.Size = new Size(55, 25);
            RbSim5.TabIndex = 28;
            RbSim5.TabStop = true;
            RbSim5.Tag = "Pergunta 5";
            RbSim5.Text = "Sim";
            RbSim5.UseVisualStyleBackColor = false;
            RbSim5.CheckedChanged += RbSim5_CheckedChanged;
            // 
            // RbNao5
            // 
            RbNao5.AutoSize = true;
            RbNao5.BackColor = Color.Transparent;
            RbNao5.Font = new Font("Segoe UI", 12F);
            RbNao5.ForeColor = SystemColors.ButtonHighlight;
            RbNao5.Location = new Point(8, 29);
            RbNao5.Name = "RbNao5";
            RbNao5.Size = new Size(57, 25);
            RbNao5.TabIndex = 29;
            RbNao5.TabStop = true;
            RbNao5.Tag = "Pergunta 5";
            RbNao5.Text = "Não";
            RbNao5.UseVisualStyleBackColor = false;
            RbNao5.CheckedChanged += RbNao5_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(RbSim);
            groupBox1.Controls.Add(RbNao);
            groupBox1.ForeColor = Color.Transparent;
            groupBox1.Location = new Point(361, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 54);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Tag = "Pergunta 1";
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(RbSim2);
            groupBox2.Controls.Add(RbNao2);
            groupBox2.ForeColor = Color.Transparent;
            groupBox2.Location = new Point(361, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 54);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Tag = "Pergunta 2";
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(RbSim3);
            groupBox3.Controls.Add(RbNao3);
            groupBox3.ForeColor = Color.Transparent;
            groupBox3.Location = new Point(361, 394);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 54);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Tag = "Pergunta 3";
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(RbSim4);
            groupBox4.Controls.Add(RbNao4);
            groupBox4.ForeColor = Color.Transparent;
            groupBox4.Location = new Point(361, 476);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 54);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Tag = "Pergunta 4";
            groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(RbSim5);
            groupBox5.Controls.Add(RbNao5);
            groupBox5.ForeColor = Color.Transparent;
            groupBox5.Location = new Point(361, 558);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 54);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            groupBox5.Tag = "Pergunta 5";
            groupBox5.Text = "groupBox5";
            // 
            // Avaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1334, 621);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Avaliar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Name = "Avaliacao";
            Text = "Avaliação da Obra 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTitulo;
        public Label label2;
        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Label label3;

        public string GetDebuggerDisplay()
        {
            return ToString();
        }
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public Button Btn_Avaliar;
        private RadioButton RbSim;
        private RadioButton RbNao;
        private RadioButton RbNao2;
        private RadioButton RbSim2;
        private RadioButton RbNao3;
        private RadioButton RbSim3;
        private RadioButton RbNao5;
        private RadioButton RbSim5;
        private RadioButton RbNao4;
        private RadioButton RbSim4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}