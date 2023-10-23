using BLL.DAL.EF;
using DAL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Treatments
{
    public class LichsukhamService
    {
        public void Addlsk(LichSuKham ls)
        {
            EFModels context = new EFModels();
            if (ls != null)
            {
                context.LichSuKhams.AddOrUpdate(ls);
                context.SaveChanges();
                //return 1;
            }

        }
    }
}
