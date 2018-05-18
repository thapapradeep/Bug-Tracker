using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Forms.Model
{
    class BugHistory
    {
        public int id { set; get; }
        public int bug_id { set; get; }
        public int user_id { set; get; }
        public DateTime attempted_date { get; set; }
        public string status { get; set; }
        public string code_block { set; get; }
    }
}
