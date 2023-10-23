using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Linq;

namespace BLL.BLL.HomeScreen.AP.newAP
{
    public class newAP
    {
        public LichSuKham AddLichSuKham(DateTime ngayKham, int maHoaDon, int maNhanVien, int maBenhNhan)
        {
            using (var dbContext = new EFModels())
            {
                if (!CheckMaHoaDonExist(maHoaDon) || !CheckMaNhanVienExist(maNhanVien) || !CheckMaBenhNhanExist(maBenhNhan))
                {
                    throw new Exception(" Ma Hoa Don, Ma Nhan Vien, hoac Ma Benh Nhan khong hop le. Hay nhap chinh xac thong tin!");
                }

                var newLichSuKham = new LichSuKham
                {
                    ngayKham = ngayKham,
                    maHoaDon = maHoaDon,
                    maNhanVien = maNhanVien,
                    maBenhNhan = maBenhNhan
                };

                dbContext.LichSuKhams.Add(newLichSuKham);
                dbContext.SaveChanges();

                return newLichSuKham;
            }
        }

        public bool CheckMaHoaDonExist(int maHoaDon)
        {
            using (var dbContext = new EFModels())
            {
                return dbContext.HoaDons.Any(h => h.maHoaDon == maHoaDon);
            }
        }

        public bool CheckMaNhanVienExist(int maNhanVien)
        {
            using (var dbContext = new EFModels())
            {
                return dbContext.ThongTinNhanViens.Any(nv => nv.maNhanVien == maNhanVien);
            }
        }

        public bool CheckMaBenhNhanExist(int maBenhNhan)
        {
            using (var dbContext = new EFModels())
            {
                return dbContext.ThongTinBenhNhans.Any(bn => bn.maBenhNhan == maBenhNhan);
            }
        }
    }
}