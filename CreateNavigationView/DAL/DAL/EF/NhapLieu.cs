namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapLieu")]
    public partial class NhapLieu
    {
        [Key]
        public int maNhap { get; set; }

        public int maVatLieu { get; set; }

        public int maNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay { get; set; }

        public int soLuong { get; set; }

        public int donGia { get; set; }

        public int thanhTien { get; set; }

        public virtual ThongTinNhanVien ThongTinNhanVien { get; set; }

        public virtual VatLieu VatLieu { get; set; }
    }
}
