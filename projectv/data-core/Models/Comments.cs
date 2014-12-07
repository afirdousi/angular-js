using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_core.Models
{
    public class Comments
    {
        public int ID { get; set; }
        public int ProjectId { get; set; }
        public int MemberId { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public bool ByManager { get; set; }
        public bool IsNotificaiton { get; set; }
    }
}