using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("tbTag")]
    public class Tag : BaseEntity
    {

        public Tag()
        {

        }

        public string title { get; set; }
        public string metaTitle { get; set; }
        public string slug { get; set; }

        public string content{ get; set; }
    }
}
