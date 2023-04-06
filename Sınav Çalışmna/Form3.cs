using Sınav_Çalışmna.Context;
using Sınav_Çalışmna.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sınav_Çalışmna
{
    public partial class Form3 : Form
    {
        DBAlbumContext db = new DBAlbumContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DGV_Albümler.DataSource = db.Album.ToList();
            DGV_SatıdıDuran.DataSource = db.Album.Where(x => x.SatışıVarMı == false).ToList();
            DGV_SatısıDevamEden.DataSource = db.Album.Where(x => x.SatışıVarMı == true).ToList();
            //DGV_EnSonEklenen.DataSource = db.Album.OrderByDescending(x => x.Tarih).Take(10);
            //DGV_IndirimliAlbum.DataSource = db.Album

            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Album yeniAlbum = new Album();
            yeniAlbum.AlbunName = txt_AlbumAdı.Text;
            yeniAlbum.Sanatci = txt_Sanatcı.Text;
            yeniAlbum.Tarih = dateTimePicker1.Value;
            yeniAlbum.Fiyat = decimal.Parse(txt_Fiyat.Text);
            if (txt_Indirim.Text != null && txt_Indirim.Text != " " && txt_Indirim.Text != "")
            {
                yeniAlbum.Indirim = decimal.Parse(txt_Indirim.Text);
            }
            
            if (rdb_True.Checked)
            {
                yeniAlbum.SatışıVarMı = true;
            }
            else if (rdb_False.Checked)
            {
                yeniAlbum.SatışıVarMı = false;
            }
            db.Album.Add(yeniAlbum);
            db.SaveChanges();
            DGV_Albümler.DataSource = db.Album.ToList();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {


            Album GüncellenecekAlbum = db.Album.Find(DGV_Albümler.SelectedRows[0].Cells[0].Value);
            GüncellenecekAlbum.AlbunName = txt_AlbumAdı.Text;
            GüncellenecekAlbum.Sanatci = txt_Sanatcı.Text;
            GüncellenecekAlbum.Tarih = dateTimePicker1.Value;
            GüncellenecekAlbum.Fiyat = decimal.Parse(txt_Fiyat.Text);
            if (txt_Indirim.Text != null && txt_Indirim.Text != " " && txt_Indirim.Text != "")
            {
                GüncellenecekAlbum.Indirim = decimal.Parse(txt_Indirim.Text);
            }
            
            db.SaveChanges();

            DGV_Albümler.DataSource = db.Album.ToList();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Album GüncellenecekAlbum = db.Album.Find(DGV_Albümler.SelectedRows[0].Cells[0].Value);
            db.Album.Remove(GüncellenecekAlbum);
            db.SaveChanges();
            DGV_Albümler.DataSource = db.Album.ToList();

        }
    }
}
