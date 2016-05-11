using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    class RAssetTransaction
    {
        public string asset_id { get; set; }
	    public string asset_addr_from { get; set; }
	    public string asset_addr_to { get; set; }
	    public string name_short { get; set; }
	    public string name { get; set; }
	    public string categotry { get; set; }
	    public string tag { get; set; }
        public long tx_time { get; set; }
    }
}
