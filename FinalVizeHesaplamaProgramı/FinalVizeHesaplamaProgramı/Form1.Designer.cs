namespace FinalVizeHesaplamaProgramı
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrtalamaLabel = new System.Windows.Forms.Label();
            this.HarfNotuLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HesaplaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VizeText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final Vize Hesaplama";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrtalamaLabel);
            this.panel2.Controls.Add(this.HarfNotuLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(20, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 186);
            this.panel2.TabIndex = 1;
            // 
            // OrtalamaLabel
            // 
            this.OrtalamaLabel.AutoSize = true;
            this.OrtalamaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrtalamaLabel.Location = new System.Drawing.Point(304, 32);
            this.OrtalamaLabel.Name = "OrtalamaLabel";
            this.OrtalamaLabel.Size = new System.Drawing.Size(19, 15);
            this.OrtalamaLabel.TabIndex = 3;
            this.OrtalamaLabel.Text = "95";
            this.OrtalamaLabel.Click += new System.EventHandler(this.OrtalamaLabel_Click);
            // 
            // HarfNotuLabel
            // 
            this.HarfNotuLabel.AutoSize = true;
            this.HarfNotuLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HarfNotuLabel.Location = new System.Drawing.Point(304, 83);
            this.HarfNotuLabel.Name = "HarfNotuLabel";
            this.HarfNotuLabel.Size = new System.Drawing.Size(23, 15);
            this.HarfNotuLabel.TabIndex = 2;
            this.HarfNotuLabel.Text = "AA";
            this.HarfNotuLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Harf Notunuz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ortalamanız :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HesaplaButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FinalText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VizeText);
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 182);
            this.panel1.TabIndex = 0;
            // 
            // HesaplaButton
            // 
            this.HesaplaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HesaplaButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HesaplaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HesaplaButton.Location = new System.Drawing.Point(307, 123);
            this.HesaplaButton.Name = "HesaplaButton";
            this.HesaplaButton.Size = new System.Drawing.Size(100, 23);
            this.HesaplaButton.TabIndex = 4;
            this.HesaplaButton.Text = "Hesapla";
            this.HesaplaButton.UseVisualStyleBackColor = false;
            this.HesaplaButton.Click += new System.EventHandler(this.HesaplaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final Notunu Giriniz :";
            // 
            // FinalText
            // 
            this.FinalText.Location = new System.Drawing.Point(307, 81);
            this.FinalText.Name = "FinalText";
            this.FinalText.Size = new System.Drawing.Size(100, 23);
            this.FinalText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vize Notunu Giriniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VizeText
            // 
            this.VizeText.Location = new System.Drawing.Point(307, 41);
            this.VizeText.Name = "VizeText";
            this.VizeText.Size = new System.Drawing.Size(100, 23);
            this.VizeText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private TextBox VizeText;
        private Label label2;
        private TextBox FinalText;
        private Panel panel2;
        private Button HesaplaButton;
        private Label OrtalamaLabel;
        private Label HarfNotuLabel;
        private Label label4;
        private Label label3;
    }
}