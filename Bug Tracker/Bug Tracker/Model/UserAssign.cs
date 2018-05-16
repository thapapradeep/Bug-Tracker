using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Forms.Model
{
    class UserAssign
    {
        public int user_id { set; get; }
        public int bug_id { set; get; }
        public string description { set; get; }
        public int assigned_by{ set; get; }
    }
}
