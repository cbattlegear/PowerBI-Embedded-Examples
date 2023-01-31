using System.Collections.Generic;

namespace AppOwnsData.Models
{
    public class EmbedParamsQnA : EmbedParams
    {
        // Report to be embedded
        public List<EmbedQnA> EmbedQnA { get; set; }
    }
}
