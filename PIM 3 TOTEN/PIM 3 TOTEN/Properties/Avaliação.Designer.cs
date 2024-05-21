using System.Diagnostics;

namespace PIM_3_TOTEN.Properties
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class Avaliação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avaliação));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(128, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 33);
            label1.TabIndex = 0;
            label1.Text = "Avaliação";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 81);
            label2.Name = "label2";
            label2.Size = new Size(246, 19);
            label2.TabIndex = 1;
            label2.Text = "Avalie a obra com uma nota de 1 a 5";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Calibri", 14.25F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(70, 116);
            button1.Name = "button1";
            button1.Size = new Size(42, 54);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Calibri", 14.25F);
            button2.Location = new Point(262, 116);
            button2.Name = "button2";
            button2.Size = new Size(42, 54);
            button2.TabIndex = 3;
            button2.Text = "5";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("Calibri", 14.25F);
            button3.Location = new Point(214, 116);
            button3.Name = "button3";
            button3.Size = new Size(42, 54);
            button3.TabIndex = 4;
            button3.Text = "4";
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Calibri", 14.25F);
            button4.Location = new Point(166, 116);
            button4.Name = "button4";
            button4.Size = new Size(42, 54);
            button4.TabIndex = 5;
            button4.Text = "3";
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Font = new Font("Calibri", 14.25F);
            button5.Location = new Point(118, 116);
            button5.Name = "button5";
            button5.Size = new Size(42, 54);
            button5.TabIndex = 6;
            button5.Text = "2";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 263);
            label3.Name = "label3";
            label3.Size = new Size(287, 15);
            label3.TabIndex = 7;
            label3.Text = "1-A obra desperta uma resposta emocional em você?";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 293);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "Sim / Não";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(149, 196);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 9;
            label4.Text = "Questionario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 10;
            label5.Text = "Responda sim ou não";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            textBox2.Text = "Sim / Não";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(12, 338);
            label6.Name = "label6";
            label6.Size = new Size(242, 15);
            label6.TabIndex = 11;
            label6.Text = "2-A composição da obra parece equilibrada?";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 446);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            textBox3.Text = "Sim / Não";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(12, 416);
            label7.Name = "label7";
            label7.Size = new Size(344, 15);
            label7.TabIndex = 13;
            label7.Text = "3-Os elementos principais da obra são facilmente identificáveis?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 531);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 16;
            textBox4.Text = "Sim / Não";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(12, 501);
            label8.Name = "label8";
            label8.Size = new Size(377, 15);
            label8.TabIndex = 15;
            label8.Text = "4-As referencias na obra tras a lembransa o sentimento do momento ?";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 611);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            textBox5.Text = "Sim / Não";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(12, 581);
            label9.Name = "label9";
            label9.Size = new Size(255, 15);
            label9.TabIndex = 17;
            label9.Text = "5-A obra parece bem executada tecnicamente?";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(149, 650);
            button6.Name = "button6";
            button6.Size = new Size(92, 36);
            button6.TabIndex = 19;
            button6.Text = "Avaliar";
            button6.UseCompatibleTextRendering = true;
            button6.UseVisualStyleBackColor = false;
            // 
            // Avaliação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(389, 698);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Avaliação";
            Text = "Avaliação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

       public Label label1;
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

        public TextBox textBox1;
        public Label label4;
        public Label label5;
        public TextBox textBox2;
        public Label label6;
        public TextBox textBox3;
        public Label label7;
        public TextBox textBox4;
        public Label label8;
        public TextBox textBox5;
        public Label label9;
        public Button button6;
    }
}