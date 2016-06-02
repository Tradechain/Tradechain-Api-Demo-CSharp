using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradechainApiDemoCSharp
{
    class RAssetCreate
    {
        public string asset_id { get; set; }
        public string asset_metadata { get; set; }
        public string txid { get; set; }
        public string hash_mutation { get; set; }
        public long create_time { get; set; }
        public int error_code { get; set; }
    }
}
