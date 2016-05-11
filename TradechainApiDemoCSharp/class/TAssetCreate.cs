using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    public class TAssetCreate
    {
        public TAuth auth= new TAuth();
	
	    public string type { get; set; }
	    public string name { get; set; }
	    public string name_short { get; set; }
	    public string description { get; set; }
	    public string icon_url { get; set; }
	    public string image_url { get; set; }
	    public string cover_url { get; set; }
	    public string attachment_url { get; set; }
	    public string hash_attachment { get; set; }
	    public long valid_time { get; set; }
	    public long invalid_time { get; set; }
	    public string tag { get; set; }
    }
}
