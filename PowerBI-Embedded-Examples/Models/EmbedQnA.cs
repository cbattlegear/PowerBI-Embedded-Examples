// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace AppOwnsData.Models
{
    using System;
    using System.Collections.Generic;

    public class EmbedQnA
    {
        // Id of Power BI report to be embedded
        public IList<Guid> DatasetIds { get; set; }

        // Embed URL for the Power BI report
        public string EmbedUrl { get; set; }
    }
}
