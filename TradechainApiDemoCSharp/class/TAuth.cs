using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    public class TAuth
    {
        public string apikey { get; set; }
	    public string signhash { get; set; }
	    public string software { get; set; }
	    public long time { get; set; }
    }
}
