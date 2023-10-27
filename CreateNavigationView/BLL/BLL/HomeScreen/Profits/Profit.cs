using BLL.DAL.EF;
using NavigationView.widgets.HomeScreen;
using System.Collections.Generic;
using System.Linq;
/*using static BLL.DAL.EF.EFModels;*/
using DAL.DAL.EF;
using static DAL.DAL.EF.EFModels;

namespace BLL.DAL
{
    internal class Profit
    {
        public List<ChartData> GetProfits()
        {
            using (var context = new EFModels())
            {
                var hoaDons = context.HoaDons.ToList(); 

                return hoaDons
                    .GroupBy(hd => hd.ngayThanhToan.TruncateTimee())
                    .Select(g => new ChartData { Ngay = g.Key, Profit = g.Sum(hd => hd.tongSoTien) })
                    .ToList();
            }
        }
    }
}
