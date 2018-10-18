using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCenfotec.Models
{
    public class WikiTops
    {
        public class UnexpandedWikiaItem
        {
            public string name { get; set; }
            public string domain { get; set; }
            public string id { get; set; }
            public string language { get; set; }
            public string hub { get; set; }
            public string topic { get; set; }
        }

        public class UnexpandedWikiaResultSet
        {
            public string batches { get; set; }
            public List<UnexpandedWikiaItem> items { get; set; }
            public string total { get; set; }
            public string currentBatch { get; set; }
            public string next { get; set; }
        }
    }
}
