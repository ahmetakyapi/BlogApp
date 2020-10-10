using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
   [Table("tbPostMeta")]
    public class PostMeta : BaseEntity
    {
        public PostMeta()
        {

        }

        public int postId { get; set; }
        public string key { get; set; }
        public string content { get; set; }

    }
}
