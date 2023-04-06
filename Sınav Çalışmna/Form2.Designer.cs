namespace Sınav_Çalışmna
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NewKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txt_NewSifre = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt_NewSifreYeniden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_Hata_Mesajı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı Giriniz";
            // 
            // txt_NewKullanıcıAdı
            // 
            this.txt_NewKullanıcıAdı.Location = new System.Drawing.Point(27, 57);
            this.txt_NewKullanıcıAdı.Name = "txt_NewKullanıcıAdı";
            this.txt_NewKullanıcıAdı.Size = new System.Drawing.Size(176, 22);
            this.txt_NewKullanıcıAdı.TabIndex = 1;
            // 
            // txt_NewSifre
            // 
            this.txt_NewSifre.Location = new System.Drawing.Point(27, 113);
            this.txt_NewSifre.Name = "txt_NewSifre";
            this.txt_NewSifre.Size = new System.Drawing.Size(176, 22);
            this.txt_NewSifre.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(24, 94);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 16);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Şifrenizi Giriniz";
            // 
            // txt_NewSifreYeniden
            // 
            this.txt_NewSifreYeniden.Location = new System.Drawing.Point(27, 165);
            this.txt_NewSifreYeniden.Name = "txt_NewSifreYeniden";
            this.txt_NewSifreYeniden.Size = new System.Drawing.Size(176, 22);
            this.txt_NewSifreYeniden.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sifrenizi Tekrar Giriniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Hata_Mesajı
            // 
            this.Lbl_Hata_Mesajı.AutoSize = true;
            this.Lbl_Hata_Mesajı.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Hata_Mesajı.Location = new System.Drawing.Point(24, 268);
            this.Lbl_Hata_Mesajı.Name = "Lbl_Hata_Mesajı";
            this.Lbl_Hata_Mesajı.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Hata_Mesajı.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 350);
            this.Controls.Add(this.Lbl_Hata_Mesajı);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NewSifreYeniden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NewSifre);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt_NewKullanıcıAdı);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NewKullanıcıAdı;
        private System.Windows.Forms.TextBox txt_NewSifre;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt_NewSifreYeniden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_Hata_Mesajı;
    }
}