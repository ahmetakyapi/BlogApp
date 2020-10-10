using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("TbPost")]
    public class Post : BaseEntity
    {
        public Post()
        {

        }
        public string name { get; set; }
        public int authorID { get; set; }
        public string caption { get; set; }
        public string metaTitle { get; set; }
        public string summary { get; set; }
        public bool published { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }

    }
}
