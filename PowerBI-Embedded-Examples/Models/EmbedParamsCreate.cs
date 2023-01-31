using System.Collections.Generic;

namespace AppOwnsData.Models
{
    public class EmbedParamsCreate : EmbedParams
    {
        //CreateReport to be embedded
        public List<EmbedCreate> EmbedCreate { get; set; }
    }
}
