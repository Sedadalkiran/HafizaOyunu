namespace HafizaOyunu
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "OYUNUN OYNANIŞI HAKKINDA ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(33, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 57);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Oyuna başladığınızda sizlere belirli bir süre gösterilen resim çiftlerini resimle" +
    "r gizlendikten sonra yine belirli bir süre sonra yerlerini doğru tahmin etmeye ç" +
    "alışınız.İyi Eğlenceler!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(114, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 44);
            this.button7.TabIndex = 2;
            this.button7.Text = "ANAMENÜ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(379, 270);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "OYUN HAKKINDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}