using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DAL.EF;
using DAL.DAL.EF;

namespace NavigationView.BLL.Manage
{
    public class FunctionService
    {
        public List<ChucVu> GetAll()
        {
            EFModels databaseNhaKhoa = new EFModels();
            return databaseNhaKhoa.ChucVus.ToList();
        }
    }
}
