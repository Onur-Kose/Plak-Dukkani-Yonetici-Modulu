using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınav_Çalışmna.Model
{
    public class Album
    {
        
        public int AlbumID { get; set; }
        public string AlbunName  { get; set; }
        public string Sanatci { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Indirim { get; set; }
        public bool SatışıVarMı { get; set; }

    }
}
