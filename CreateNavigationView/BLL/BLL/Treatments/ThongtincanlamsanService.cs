using BLL.DAL.EF;
using DAL.DAL.EF;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace NavigationView.BLL.Treatments
{
    public class ThongtincanlamsanService
    {
        EFModels context = new EFModels();
        public ThongTinCanLamSan Find(string sdt)
        {
            var a = context.ThongTinBenhNhans.FirstOrDefault(c => c.soDienThoai.Contains(sdt)); // constains tạo toán tử like trong sql để so sánh
            if (a != null)
            {
                var id = a.maBenhNhan;
                return context.ThongTinCanLamSans.FirstOrDefault(p => p.maBenhNhan == id);
            }
            else
            {
                return null;
            }
        }
        public int macanlamsan(int id)
        {
            List<HoaDon> h = context.HoaDons.Where(p => p.maBenhNhan == id).ToList();
            List<ThongTinCanLamSan> cls = context.ThongTinCanLamSans.Where(p => p.maBenhNhan == id).ToList();

            if (h != null)
            {
                List<ThongTinCanLamSan> thongtincanxoa = new List<ThongTinCanLamSan>();
                for (int i = 0; i < cls.Count; i++)
                {
                    for (int j = 0; j < h.Count; j++)
                    {
                        if (cls[i].maCanLamSan == h[j].maCanLamSan)
                        {
                            thongtincanxoa.Add(cls[i]);
                        }
                    }
                }

                foreach(var item in thongtincanxoa)
                {
                    cls.Remove(item);
                }    
                
                return cls[0].maCanLamSan;
                    

            }
            else
            {
                return cls[0].maCanLamSan;
            }
        }
        public int Add_Update(ThongTinCanLamSan t)
        {
            if (t != null)
            {
                context.ThongTinCanLamSans.AddOrUpdate(t);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }
        public int finfID(string sdt)
        {
            var a = context.ThongTinBenhNhans.FirstOrDefault(c => c.soDienThoai.Contains(sdt));
            if (a != null)
            {
                return a.maBenhNhan;
            }
            return -1;
        }
    }
}
