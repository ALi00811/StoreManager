using _4payeSystem.Model;

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _4payeSystem
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<TblForooshgah> TblForooshgahs { get; set; }       
        public virtual DbSet<TblKomod> TblKomods { get; set; }
        public virtual DbSet<TblTarakonesh> TblTarakoneshes { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
