using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationView.widgets.HomeScreen
{
    public static class TruncateTime
    {
        public static DateTime TruncateTimee(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }
    }
}
