namespace NongSanVietNam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiNS")]
    public partial class LoaiN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiN()
        {
            NongSans = new HashSet<NongSan>();
        }

        [Key]
        public int IDLoaiNS { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoai { get; set; }

        [StringLength(350)]
        public string HinhAnh { get; set; }

        [StringLength(1024)]
        public string MotaNgan { get; set; }

        [Required]
        [StringLength(50)]
        public string NguoiTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiCapNhat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NongSan> NongSans { get; set; }
    }
}
