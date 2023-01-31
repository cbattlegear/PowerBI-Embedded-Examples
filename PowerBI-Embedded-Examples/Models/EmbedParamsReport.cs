using System.Collections.Generic;

namespace AppOwnsData.Models
{
    public class EmbedParamsReport : EmbedParams
    {
        // Report to be embedded
        public List<EmbedReport> EmbedReport { get; set; }
    }
}
