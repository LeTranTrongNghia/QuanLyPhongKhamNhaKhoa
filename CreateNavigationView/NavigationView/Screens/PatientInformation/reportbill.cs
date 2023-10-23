using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.Screens.PatientInformation {
    internal class reportbill
    {
        public int maChuanDoan { get; set; }

        [Required]
        [StringLength(200)]
        public string noiDungChuanDoan { get; set; }

        [Required]
        [StringLength(300)]
        public string luaChonDieuTri { get; set; }

        [Required]
        [StringLength(50)]
        public string donViTinh { get; set; }

        public int soLuong { get; set; }

        public int donGia { get; set; }

        public int maBaoHanh { get; set; }

        public int thanhTien { get; set; }
    }
}


