using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Forms.Model
{
    class Bug
    {
        public int bug_id { get; set; }
        public string project_name { get; set; }
        public string class_name { get; set; }
        public string method_name { get; set; }
        public int line_number { get; set; }
        public int code_author { get; set; }
        public DateTime added_date { get; set; }

    }
}
