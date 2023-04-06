using Sınav_Çalışmna.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Sınav_Çalışmna.Context
{
    public class DBAlbumContext : DbContext
    {
        public DBAlbumContext() : base("conn")
        {

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Album> Album { get; set; }
    }
}
