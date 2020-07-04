using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M318.Exercises.Nr4_4
{
    public class BalanceChangelogEntry
    {
        public DateTime Time { get; set; }
        public decimal BalanceChange { get; set; }
        public decimal NewBalance { get; set; }
    }
}
