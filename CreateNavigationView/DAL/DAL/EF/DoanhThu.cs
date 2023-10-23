namespace DAL.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime ngay { get; set; }

        public int soLuongKhachHang { get; set; }

        public int tienNhapLieu { get; set; }

        public int tienThuNhap { get; set; }

        public int loiNhuan { get; set; }
    }
}
