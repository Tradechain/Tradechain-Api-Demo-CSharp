using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    public class RAssetBalance
    {
        public string asset_id { get; set; }
	    public string contract_url { get; set; }
	    public string name_short { get; set; }
	    public string name { get; set; }
	    public string issuer { get; set; }
	    public string description { get; set; }
	    public string description_mime { get; set; }
	    public string type { get; set; }
	    public int divisibility { get; set; }
	    public string link_to_website { get; set; }
	    public string icon_url { get; set; }
	    public string image_url { get; set; }
	    public string tag { get; set; }
        public int quantity { get; set; }
    }
}
