using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DAL.EF;
namespace NavigationView.BLL.Manage
{
    public class ExaminationHistory
    {
        public int NumberOfPatientsByDay(DateTime date)
        {
            EFModels databaseNhaKhoa = new EFModels();
            return databaseNhaKhoa.LichSuKhams.Count(p=>p.ngayKham == date);

        }

    }
}
