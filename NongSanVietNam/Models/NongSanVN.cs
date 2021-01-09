namespace NongSanVietNam.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NongSanVN : DbContext
    {
        public NongSanVN()
            : base("name=NongSanVN")
        {
        }

        public virtual DbSet<LoaiN> LoaiNS { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NongSan> NongSans { get; set; }
        public virtual DbSet<TinTuc> TinTucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiN>()
                .HasMany(e => e.NongSans)
                .WithRequired(e => e.LoaiN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.TinTucs)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);
        }
    }
}
