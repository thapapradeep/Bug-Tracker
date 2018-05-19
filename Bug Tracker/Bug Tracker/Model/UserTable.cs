using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Forms.Model
{
   public class UserTable
    {
        public int user_id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int type_id { get; set; }


    }
}
