using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("dbPostComment")]
    public class PostComment : BaseEntity
    {
        public PostComment()
        {
           
        }
 

        public int postId { get; set; }
        public string title { get; set; }
        public bool published { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }

    }
}
