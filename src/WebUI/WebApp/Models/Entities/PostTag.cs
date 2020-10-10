using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("tbPostTag")]
    public class PostTag : BaseEntity
    {
        public PostTag()
        {

        }
        public int tagId { get; set; }
        public int postId { get; set; }
        

    }
}
