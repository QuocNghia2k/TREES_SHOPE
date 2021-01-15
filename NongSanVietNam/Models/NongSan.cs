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
        [Display(Name = "Tên cây cảnh")]
        [StringLength(50)]
        public string TenNS { get; set; }

        [Display(Name = "Loại cây cảnh")]
        public int IDLoaiNS { get; set; }
        public int Gia { get; set; }

        [StringLength(550)]
        [Display(Name = "Mô tả ngắn")]
        public string MoTaNgan { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Bài viết chi tiết")]
        public string MotaChiTiet { get; set; }
        

        [Column(TypeName = "date")]
        [Display(Name = "Ngày tạo")]
        public DateTime NgayTao { get; set; }

        [Required]
        [Display(Name = "Người tạo")]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày cập nhật")]
        public DateTime? NgayCapNhat { get; set; }

        [StringLength(50)]
        [Display(Name = "Người cập nhật")]
        public string NguoiCapNhat { get; set; }

        [StringLength(350)]
        [Display(Name = "Ảnh đại diện")]
        public string HinhAnhDaiDien { get; set; }

        public virtual LoaiN LoaiN { get; set; }
    }
}
