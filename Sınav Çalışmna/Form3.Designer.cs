namespace Sınav_Çalışmna
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_False = new System.Windows.Forms.RadioButton();
            this.rdb_True = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Indirim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sanatcı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AlbumAdı = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.DGV_Albümler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_SatıdıDuran = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGV_SatısıDevamEden = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGV_EnSonEklenen = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DGV_IndirimliAlbum = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Albümler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SatıdıDuran)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SatısıDevamEden)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EnSonEklenen)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_IndirimliAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(28, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rdb_False);
            this.tabPage1.Controls.Add(this.rdb_True);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_Indirim);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Fiyat);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Sanatcı);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_AlbumAdı);
            this.tabPage1.Controls.Add(this.btn_Sil);
            this.tabPage1.Controls.Add(this.btn_Guncelle);
            this.tabPage1.Controls.Add(this.btn_Ekle);
            this.tabPage1.Controls.Add(this.DGV_Albümler);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tüm Albümler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zorunlu alanlar \" * \" ile gösretilmiştir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(765, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Satışta MI?";
            // 
            // rdb_False
            // 
            this.rdb_False.AutoSize = true;
            this.rdb_False.Location = new System.Drawing.Point(953, 212);
            this.rdb_False.Name = "rdb_False";
            this.rdb_False.Size = new System.Drawing.Size(60, 20);
            this.rdb_False.TabIndex = 15;
            this.rdb_False.TabStop = true;
            this.rdb_False.Text = "Hayır";
            this.rdb_False.UseVisualStyleBackColor = true;
            // 
            // rdb_True
            // 
            this.rdb_True.AutoSize = true;
            this.rdb_True.Location = new System.Drawing.Point(880, 212);
            this.rdb_True.Name = "rdb_True";
            this.rdb_True.Size = new System.Drawing.Size(55, 20);
            this.rdb_True.TabIndex = 14;
            this.rdb_True.TabStop = true;
            this.rdb_True.Text = "Evet";
            this.rdb_True.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "İndirim";
            // 
            // txt_Indirim
            // 
            this.txt_Indirim.Location = new System.Drawing.Point(839, 171);
            this.txt_Indirim.Name = "txt_Indirim";
            this.txt_Indirim.Size = new System.Drawing.Size(200, 22);
            this.txt_Indirim.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fiyat*";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(839, 143);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(200, 22);
            this.txt_Fiyat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarih*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sanatçı*";
            // 
            // txt_Sanatcı
            // 
            this.txt_Sanatcı.Location = new System.Drawing.Point(839, 69);
            this.txt_Sanatcı.Name = "txt_Sanatcı";
            this.txt_Sanatcı.Size = new System.Drawing.Size(200, 22);
            this.txt_Sanatcı.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Albüm Adı*";
            // 
            // txt_AlbumAdı
            // 
            this.txt_AlbumAdı.Location = new System.Drawing.Point(839, 34);
            this.txt_AlbumAdı.Name = "txt_AlbumAdı";
            this.txt_AlbumAdı.Size = new System.Drawing.Size(200, 22);
            this.txt_AlbumAdı.TabIndex = 4;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(777, 358);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(262, 54);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(777, 298);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(262, 54);
            this.btn_Guncelle.TabIndex = 2;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(777, 238);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(262, 54);
            this.btn_Ekle.TabIndex = 1;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // DGV_Albümler
            // 
            this.DGV_Albümler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Albümler.Location = new System.Drawing.Point(6, 6);
            this.DGV_Albümler.Name = "DGV_Albümler";
            this.DGV_Albümler.RowHeadersWidth = 51;
            this.DGV_Albümler.RowTemplate.Height = 24;
            this.DGV_Albümler.Size = new System.Drawing.Size(753, 402);
            this.DGV_Albümler.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV_SatıdıDuran);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Satışı Durdurulmuş Albumler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGV_SatıdıDuran
            // 
            this.DGV_SatıdıDuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SatıdıDuran.Location = new System.Drawing.Point(6, 6);
            this.DGV_SatıdıDuran.Name = "DGV_SatıdıDuran";
            this.DGV_SatıdıDuran.RowHeadersWidth = 51;
            this.DGV_SatıdıDuran.RowTemplate.Height = 24;
            this.DGV_SatıdıDuran.Size = new System.Drawing.Size(1050, 402);
            this.DGV_SatıdıDuran.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGV_SatısıDevamEden);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1062, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Satışı Devam Eden Albumler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGV_SatısıDevamEden
            // 
            this.DGV_SatısıDevamEden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SatısıDevamEden.Location = new System.Drawing.Point(3, 6);
            this.DGV_SatısıDevamEden.Name = "DGV_SatısıDevamEden";
            this.DGV_SatısıDevamEden.RowHeadersWidth = 51;
            this.DGV_SatısıDevamEden.RowTemplate.Height = 24;
            this.DGV_SatısıDevamEden.Size = new System.Drawing.Size(1050, 402);
            this.DGV_SatısıDevamEden.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGV_EnSonEklenen);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1062, 414);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "En Son Eklenen 10 Album";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGV_EnSonEklenen
            // 
            this.DGV_EnSonEklenen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EnSonEklenen.Location = new System.Drawing.Point(6, 6);
            this.DGV_EnSonEklenen.Name = "DGV_EnSonEklenen";
            this.DGV_EnSonEklenen.RowHeadersWidth = 51;
            this.DGV_EnSonEklenen.RowTemplate.Height = 24;
            this.DGV_EnSonEklenen.Size = new System.Drawing.Size(1050, 402);
            this.DGV_EnSonEklenen.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGV_IndirimliAlbum);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1062, 414);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "İndirimdeki Albumler";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DGV_IndirimliAlbum
            // 
            this.DGV_IndirimliAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_IndirimliAlbum.Location = new System.Drawing.Point(6, 6);
            this.DGV_IndirimliAlbum.Name = "DGV_IndirimliAlbum";
            this.DGV_IndirimliAlbum.RowHeadersWidth = 51;
            this.DGV_IndirimliAlbum.RowTemplate.Height = 24;
            this.DGV_IndirimliAlbum.Size = new System.Drawing.Size(1050, 402);
            this.DGV_IndirimliAlbum.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(839, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Albümler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SatıdıDuran)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SatısıDevamEden)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EnSonEklenen)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_IndirimliAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridView DGV_Albümler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_SatıdıDuran;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGV_SatısıDevamEden;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGV_EnSonEklenen;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView DGV_IndirimliAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_False;
        private System.Windows.Forms.RadioButton rdb_True;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Indirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sanatcı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AlbumAdı;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}