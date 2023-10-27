using BLL.DAL.EF;
using System.Linq;
/*using static BLL.DAL.EF.EFModels;*/
using DAL.DAL.EF;
using static DAL.DAL.EF.EFModels;

namespace BLL.BLL.EF
{
    public class BillService
    {
        private EFModels _dbContext;

        public BillService()
        {
            _dbContext = new EFModels();
        }

        public Bill GetBillDetails(string maHoaDon)
        {
            // Kiểm tra mã hóa đơn có tồn tại trong cơ sở dữ liệu không
            var bill = _dbContext.HoaDons.FirstOrDefault(b => b.maHoaDon.ToString() == maHoaDon);
            if (bill == null)
            {
                return null;
            }

            // Lấy thông tin từ các bảng liên quan
            var maBenhNhan = bill.maBenhNhan;
            var tenBenhNhan = _dbContext.ThongTinBenhNhans.FirstOrDefault(t => t.maBenhNhan == maBenhNhan)?.tenBenhNhan;
            var maCanLamSan = bill.maCanLamSan;

            // Sử dụng join query để lấy noiDungChuanDoan và luaChonDieuTri từ bảng ChuanDoanDieuTri
            var chuanDoan = (from ttls in _dbContext.ThongTinLamSans
                             join cddt in _dbContext.ChuanDoanDieuTris on ttls.maChuanDoan equals cddt.maChuanDoan
                             where ttls.maChuanDoan == maCanLamSan
                             select cddt).FirstOrDefault();

            var noiDungChuanDoan = chuanDoan?.noiDungChuanDoan;
            var luaChonDieuTri = chuanDoan?.luaChonDieuTri;

            var tongSoTien = bill.tongSoTien;

            // Tạo đối tượng Bill chứa thông tin
            var billDetails = new Bill
            {
                maHoaDon = maHoaDon,
                MaBenhNhan = maBenhNhan,
                TenBenhNhan = tenBenhNhan,
                MaCanLamSan = maCanLamSan,
                NoiDungChuanDoan = noiDungChuanDoan,
                LuaChonDieuTri = luaChonDieuTri,
                TongSoTien = tongSoTien
            };

            return billDetails;
        }
    }
}