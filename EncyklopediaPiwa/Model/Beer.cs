using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyklopediaPiwa.Model
{
    [Flags]
    public enum Country
    {
        Unknown=0,
        Polish=1,
        English=2,
        Ireland=4,
        German=8,
        Czech=16
    }
    
    public class Beer
    {
        public long Id { get; set; }

        public decimal Voltage { get; set; }

        public string Name { get; set; }

        public int Country { get; set; }
    }
}
