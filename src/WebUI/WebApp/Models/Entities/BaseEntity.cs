using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            
        }
        [Key]
        public int Id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }


    }
}
