using BLL.DAL.EF;
using DAL.DAL.EF;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace NavigationView.BLL.Treatments
{
    public class ThongtinlamsanService
    {
        EFModels context = new EFModels();
        public int Add_Update(ThongTinLamSan t)
        {
            if (t != null)
            {
                context.ThongTinLamSans.AddOrUpdate(t);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }
        public string noidungchuandoan(int a)
        {
            return context.ChuanDoanDieuTris
                        .Where(p => p.maChuanDoan == a)
                        .Select(p => p.noiDungChuanDoan)
                        .FirstOrDefault();
        }
        public string noidungdieutri(int a)
        {
            return context.ChuanDoanDieuTris
                        .Where(c => c.maChuanDoan == a)
                        .Select(c => c.luaChonDieuTri.ToString()).FirstOrDefault();
        }
        public List<ThongTinLamSan> getThongtinbenh(int mab)
        {
            EFModels context = new EFModels();
            List<ThongTinLamSan> listLamsan = context.ThongTinLamSans.Where(p => p.maBenhNhan == mab).ToList(); // lấy ra nhưng thông tin lâm sàn có mã chuẩn đoán  =  macd mà mình cần xóa
            List<HoaDon> listLamsancu = context.HoaDons.Where(p => p.maBenhNhan == mab).ToList();//lấy ra thông tin mã lâm sàn của bệnh nhân cần tìm đã tồn tại trước đó
            if (listLamsancu != null)
            {
                List<ThongTinLamSan> thongtinlamsancanxoa = new List<ThongTinLamSan>();
                for (int i = 0; i < listLamsan.Count; i++)
                {
                    for (int j = 0; j < listLamsancu.Count; j++)
                    {
                        if (listLamsan[i].maLamSan == listLamsancu[j].maLamSan)
                        {
                            thongtinlamsancanxoa.Add(listLamsan[i]);
                            break;
                        }
                    }
                }
                foreach (var delete in thongtinlamsancanxoa)
                {
                    listLamsan.Remove(delete);
                }
                return listLamsan;
            }
            return listLamsan;
        }
    }
}
