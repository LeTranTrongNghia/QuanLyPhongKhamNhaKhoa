using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Treatments
{
    public class HoadonService
    {
        public int Addhd(HoaDon h)
        {
            EFModels context = new EFModels();
            if (h != null)
            {
                context.HoaDons.Add(h);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }
        public List<HoaDon> Hoadoncuabenhnhan(int mabn)
        {
            EFModels context = new EFModels();
            return context.HoaDons.Where(p => p.maBenhNhan == mabn && p.ngayThanhToan == DateTime.Today.Date).ToList();
        }
    }
}
