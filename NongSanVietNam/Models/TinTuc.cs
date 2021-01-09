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
        [Display(Name = "Mã tin")]
        public int IDTinTuc { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; }

        [StringLength(550)]
        [Display(Name = "Mô tả ngắn")]
        public string MotaNgan { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Bài viết chi tiết")]
        public string BaiVietChiTiet { get; set; }

        [Display(Name = "Mã User")]
        public int UserID { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime NgayTao { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? NgayCapNhat { get; set; }
        
        [StringLength(350)]
        [Display(Name = "Ảnh đại diện")]
        public string HinhAnhDaiDien { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
