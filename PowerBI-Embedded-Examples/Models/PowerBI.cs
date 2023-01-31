// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace AppOwnsData.Models
{
    public class PowerBI
    {
        // Workspace Id for which Embed token needs to be generated
        public string WorkspaceId { get; set; }

        // Report Id for which Embed token needs to be generated
        public string ReportId { get; set; }

        // Paginated Report Id for which Embed token needs to be generated
        public string PaginatedReportId { get; set; }

        // Dataset Id for Report Creation
        public string DatasetId { get; set; }

        // RLS Report Id for which Embed token needs to be generated
        public string RLSReportId { get; set; }

        public string RLSDataSetId { get; set; }
    }
}
