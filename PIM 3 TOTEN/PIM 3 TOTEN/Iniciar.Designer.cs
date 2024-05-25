namespace PIM_3_TOTEN
{
    partial class Iniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar));
            Btn_Iniciar = new Button();
            SuspendLayout();
            // 
            // Btn_Iniciar
            // 
            Btn_Iniciar.BackColor = SystemColors.ActiveCaption;
            Btn_Iniciar.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Iniciar.Location = new Point(336, 243);
            Btn_Iniciar.Name = "Btn_Iniciar";
            Btn_Iniciar.Size = new Size(128, 66);
            Btn_Iniciar.TabIndex = 1;
            Btn_Iniciar.Text = "Iniciar";
            Btn_Iniciar.UseVisualStyleBackColor = false;
            Btn_Iniciar.Click += Btn_Iniciar_Click;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(828, 538);
            Controls.Add(Btn_Iniciar);
            Name = "Iniciar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "iniciar";
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_Iniciar;
    }
}
