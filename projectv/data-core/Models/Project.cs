using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_core.Models
{
    public class Project
    {
        public Project()
        { }

        public Project(int id,string Name, int ManagerId, string Description, DateTime StartDate, DateTime ExpectedEndDate)
        {
            this.ID = id;
            this.Name = Name;
            this.ManagerId = ManagerId;
            this.Description = Description;
            this.StartDate = StartDate;
            this.ExpectedEndDate = ExpectedEndDate;
            
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public List<Member> TeamMembers { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public List<DateTime> EndDateHistory { get; set; }
        public List<Comments> Comments { get; set; }



    }
}