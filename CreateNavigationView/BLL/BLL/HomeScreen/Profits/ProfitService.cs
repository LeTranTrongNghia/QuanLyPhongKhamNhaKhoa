using BLL.DAL;
using System.Collections.Generic;
using static BLL.DAL.EF.EFModels;

namespace BLL.BLL
{
    public class ProfitService
    {
        private Profit dataAccess = new Profit();
         
        public List<ChartData> GetProfitsForChart()
        {
            var profits = dataAccess.GetProfits();
            return profits;
        }
    }
}