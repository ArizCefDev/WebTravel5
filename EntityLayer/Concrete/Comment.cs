using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string CommentUser { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
