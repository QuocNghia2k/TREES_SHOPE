namespace NongSanVietNam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        public int IDTinTuc { get; set; }

        [Required]
        [StringLength(250)]
        public string TieuDe { get; set; }

        [StringLength(550)]
        public string MotaNgan { get; set; }

        [Column(TypeName = "ntext")]
        public string BaiVietChiTiet { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [StringLength(350)]
        public string HinhAnhDaiDien { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
