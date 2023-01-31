namespace AppOwnsData.Models
{
    using System;
    public class EmbedCreate
    {
        public Guid DatasetId { get; set; }

        // Embed URL for the Power BI report
        public string EmbedUrl { get; set; }
    }
}
