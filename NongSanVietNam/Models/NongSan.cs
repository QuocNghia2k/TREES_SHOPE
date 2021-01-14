namespace NongSanVietNam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NongSan")]
    public partial class NongSan
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNS { get; set; }

        public int IDLoaiNS { get; set; }
        public int Gia { get; set; }

        [StringLength(550)]
        public string MoTaNgan { get; set; }

        [Column(TypeName = "ntext")]
        public string MotaChiTiet { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [StringLength(50)]
        public string NguoiCapNhat { get; set; }

        [StringLength(350)]
        public string HinhAnhDaiDien { get; set; }

        public virtual LoaiN LoaiN { get; set; }
    }
}
