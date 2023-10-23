using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.DAL.EF
{
    internal class AP
    {
        public bool AddItemsToTable(string tenBenhNhan, string lyDoDenKham, string ngayKham)
        {
            using (var context = new EFModels())
            {
                DateTime dateTime;
                if (!DateTime.TryParse(ngayKham, out dateTime))
                {
                    throw new FormatException("Invalid date format");
                }

                var item = new ThongTinBenhNhan
                {
                    tenBenhNhan = tenBenhNhan.Trim(),
                    lyDoDenKham = lyDoDenKham.Trim(),
                };

                context.ThongTinBenhNhans.Add(item);

                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<EFModels.AP> GetPatientInfo()
        {
            using (var context = new EFModels())
            {
                try
                {
                    var items = (from lsk in context.LichSuKhams
                                 join ttn in context.ThongTinBenhNhans on lsk.maBenhNhan equals ttn.maBenhNhan
                                 select new EFModels.AP
                                 {
                                     tenBenhNhan = ttn.tenBenhNhan,
                                     lyDoDenKham = ttn.lyDoDenKham,
                                     ngayKham = lsk.ngayKham
                                 }).ToList();
                    return items;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}