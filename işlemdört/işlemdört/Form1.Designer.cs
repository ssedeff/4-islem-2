namespace işlemdört
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTopla = new System.Windows.Forms.Label();
            this.lblCıkar = new System.Windows.Forms.Label();
            this.lblCarp = new System.Windows.Forms.Label();
            this.lblBol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHesapla.Location = new System.Drawing.Point(68, 64);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 41);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAYI 1:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(68, 12);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(68, 38);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SAYI 2:";
            // 
            // lblTopla
            // 
            this.lblTopla.AutoSize = true;
            this.lblTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopla.Location = new System.Drawing.Point(174, 12);
            this.lblTopla.Name = "lblTopla";
            this.lblTopla.Size = new System.Drawing.Size(107, 25);
            this.lblTopla.TabIndex = 5;
            this.lblTopla.Text = "Toplama: ";
            // 
            // lblCıkar
            // 
            this.lblCıkar.AutoSize = true;
            this.lblCıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCıkar.Location = new System.Drawing.Point(175, 37);
            this.lblCıkar.Name = "lblCıkar";
            this.lblCıkar.Size = new System.Drawing.Size(103, 25);
            this.lblCıkar.TabIndex = 6;
            this.lblCıkar.Text = "Çıkarma: ";
            // 
            // lblCarp
            // 
            this.lblCarp.AutoSize = true;
            this.lblCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarp.Location = new System.Drawing.Point(174, 62);
            this.lblCarp.Name = "lblCarp";
            this.lblCarp.Size = new System.Drawing.Size(99, 25);
            this.lblCarp.TabIndex = 7;
            this.lblCarp.Text = "Çarpma: ";
            // 
            // lblBol
            // 
            this.lblBol.AutoSize = true;
            this.lblBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBol.Location = new System.Drawing.Point(174, 87);
            this.lblBol.Name = "lblBol";
            this.lblBol.Size = new System.Drawing.Size(84, 25);
            this.lblBol.TabIndex = 8;
            this.lblBol.Text = "Bölme: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 141);
            this.Controls.Add(this.lblBol);
            this.Controls.Add(this.lblCarp);
            this.Controls.Add(this.lblCıkar);
            this.Controls.Add(this.lblTopla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopla;
        private System.Windows.Forms.Label lblCıkar;
        private System.Windows.Forms.Label lblCarp;
        private System.Windows.Forms.Label lblBol;
    }
}

