using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCenfotec.Models
{
    public class WikiaInformacion
    {
        public class WikiaStats
        {
            public string users { get; set; }
            public string articles { get; set; }
            public string pages { get; set; }
            public string admins { get; set; }
            public string activeUsers { get; set; }
            public string edits { get; set; }
            public string videos { get; set; }
            public string images { get; set; }
        }

        public class OriginalDimensions
        {
            public string width { get; set; }
            public string height { get; set; }
        }

        public class ExpandedWikiaItem
        {
            public string headline { get; set; }
            public string desc { get; set; }
            public string name { get; set; }
            public WikiaStats stats { get; set; }
            public OriginalDimensions original_dimensions { get; set; }
            public string url { get; set; }
            public string image { get; set; }
            public List<string> flags { get; set; }
            public string domain { get; set; }
            public string wam_score { get; set; }
            public string id { get; set; }
            public string lang { get; set; }
            public List<string> topUsers { get; set; }
            public string hub { get; set; }
            public string wordmark { get; set; }
            public string topic { get; set; }
            public string title { get; set; }
            public string founding_user_id { get; set; }
            public string creation_date { get; set; }
        }

        public class WikiaDetailsResultSet
        {
            public List<ExpandedWikiaItem> items1 { get; set; }
        }

        public class prueba
        {
            public WikiaDetailsResultSet items { get; set; }
        }
    }
}
