using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingSwaggerApi.Model
{
    public class PageUrlModel
    {
        public string student_unique_id  {get;set;}
        public string custom_logo { get; set; }
        public string custom_title { get; set; }
        public string return_url { get; set; }
        public string event_id { get; set; }
        public string param { get; set; }
        public string pagetype { get; set; }
        public bool autoapproval { get; set; }
        public string attemptnumber { get; set; }
        public string captureimage { get; set; }

    }
}
