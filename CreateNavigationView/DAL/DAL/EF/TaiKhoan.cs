namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(200)]
        public string taiKhoanNhanVien { get; set; }

        [Required]
        [StringLength(200)]
        public string matKhauNhanVien { get; set; }

        public int maNhanVien { get; set; }

        public virtual ThongTinNhanVien ThongTinNhanVien { get; set; }
    }
}
