using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Forms.Model
{
    class BugDetails
    {
        public int bug_id { get; set; }
        public string symptom { get; set; }
        public string cause { get; set; }
        public byte[] image { get; set; }
        public string image_name { get; set; }
        public string source_link { get; set; }
        public string code_block { get; set; }
    }
}
