using Sınav_Çalışmna.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Çalışmna
{
    public partial class Form1 : Form
    {
        DBAlbumContext db = new DBAlbumContext();
        public Form1()
        {
            InitializeComponent();
        }
        Form3 frm3 = new Form3();
        private void Form1_Load(object sender, EventArgs e)
        {
            //deneme kodu
            //frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pas1 = txt_Sifre.Text;
            bool EsiVarMi = false;
            bool SifreVarMi = false;
            var AdminName = db.Admin.Select(x => x.AdminName);
            foreach (var item in AdminName)
            {
                if (item == txt_KullanıcıAdı.Text)
                {
                    EsiVarMi = true;
                }
            }
            var AdminSifre = db.Admin.Select(x => x.Sifre);
            foreach (var item in AdminSifre)
            {
                if (item == sha256_hash(pas1))
                {
                    SifreVarMi = true;
                }
            }
            if (EsiVarMi == false)
            {
                lbl_Hata_Girşi.Text = "kulalnıcı adı bulunammadı";
            }
            else if(SifreVarMi == false)
            {
                lbl_Hata_Girşi.Text = "hatalı şifre girşi";
            }
            else
            {
                
                lbl_Hata_Girşi.Text = "Hoşgeldiniz";
                
                frm3.Show();

            }

        }

        private string sha256_hash(string sifre)

        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
