using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCenfotec.Models
{
    public class WikiaModel
    {
        public class WikiaItem
        {
            public string name { get; set; }
            public string domain { get; set; }
            public string id { get; set; }
            public string language { get; set; }
            public string hub { get; set; }
            public string topic { get; set; }
            public int founding_user_id { get; set; }
        }

        public class WikiaResultSet
        {
            public string batches { get; set; }
            public List<WikiaItem> items { get; set; }
            public string total { get; set; }
            public string currentBatch { get; set; }
            public string next { get; set; }
        }
    }
}
