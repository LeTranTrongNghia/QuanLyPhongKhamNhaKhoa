using BLL.DAL.EF;
using System.Collections.Generic;

namespace BLL
{
    internal class APService
    {
        private AP ap = new AP();

        public bool SaveItems(string tenBenhNhan, string lyDoDenKham, string ngayKham)
        {
            return ap.AddItemsToTable(tenBenhNhan, lyDoDenKham, ngayKham);
        }

        public List<EFModels.AP> GetItems()
        {
            return ap.GetPatientInfo();
        }
    }
}