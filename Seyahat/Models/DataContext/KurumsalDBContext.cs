using Seyahat.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seyahat.Models.DataContext
{
    public class KurumsalDBContext:DbContext
    {

        public KurumsalDBContext():base("KurumsalDB1")
        { 
       
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Hakkımızda> Hakkımızda { get; set; }
        public DbSet<Hizmet> Hizmet{ get; set; }
        public DbSet<İletişim> İletişim{ get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Kimlik> Kimlik { get; set; }
        public DbSet<Slider> Slider { get; set; }



    }
}