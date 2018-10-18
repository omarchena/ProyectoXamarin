using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCenfotec.Models
{
    public class WikiUsuarios
    {
        public class UserElement
        {
            public int user_id { get; set; }
            public string title { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public int numberofedits { get; set; }
            public string avatar { get; set; }
        }

        public class UserResultSet
        {
            public string basepath { get; set; }
            public List<UserElement> items { get; set; }
        }
    }
}
