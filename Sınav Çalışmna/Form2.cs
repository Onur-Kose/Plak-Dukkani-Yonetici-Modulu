using Sınav_Çalışmna.Context;
using Sınav_Çalışmna.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Çalışmna
{
    public partial class Form2 : Form
    {
        DBAlbumContext db = new DBAlbumContext();
        public Form2()
        {
            InitializeComponent();
            
        }
        Form1 frm1 = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            string pas = txt_NewSifre.Text;
            bool EsisizMi = true;
            var AdminName = db.Admin.Select(x => x.AdminName);
            foreach (var item in AdminName)
            {
                if (item == txt_NewKullanıcıAdı.Text)
                {
                    EsisizMi = false;
                }
            }
            if (EsisizMi == false)
            {
                Lbl_Hata_Mesajı.Text = "Böyle bir kullanıcı zaten var";
            }
            else if(txt_NewSifre.Text != txt_NewSifreYeniden.Text)
            {
                Lbl_Hata_Mesajı.Text = "Şifreler Uyuşmuyor";
            }
            else if ( IsPasswordValid(pas) != true)
            {
                Lbl_Hata_Mesajı.Text = "Şifre yeterince güvenli değil";
            }
            else
            {
                string sPasword = sha256_hash(pas);
                Admin yeniadmin = new Admin();
                yeniadmin.AdminName = txt_NewKullanıcıAdı.Text;
                yeniadmin.Sifre = sPasword;
                db.Admin.Add(yeniadmin);
                db.SaveChanges();
                Lbl_Hata_Mesajı.Text = "İşlem başarılı ilk forma dönünüz";
            }
            
            

            
        }

        private string sha256_hash(string sifre) 
        
        { 
            using (SHA256 hash = SHA256Managed.Create()) 
            { 
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); 
            } 
        }

        public bool IsPasswordValid(string password)
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[a-z])(?=.*[a-z])(?=.*[A-Z])(?=.*[A-Z])(?=.*\\d)(?=.*\\d)(?=.*[$@!%*?+#&'()[=\"€])[A-Za-z\\d$@!%*?+#&'()[=\"€']{8,}");
            return regex.IsMatch(password);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            frm1.Show();
            
        }
    }
}
