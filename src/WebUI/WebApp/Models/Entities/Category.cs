using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("Category")]
    public class Category:BaseEntity
    {
        public Category()
        {

        }

        public string name { get; set; }
       
    }
}
