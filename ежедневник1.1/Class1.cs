using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежедневник1._1
{
    internal class DayInfo
    {
        public int Day;
        public int Month;
        public string Zametka;
        public string Opisanie;
        public static List<DayInfo> DaysInfo = new List<DayInfo>();
    }
}
