using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_core.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public List<Project> Projects { get; set; }
        public int ManagerID { get; set; }
    }
}