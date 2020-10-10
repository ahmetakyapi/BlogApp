using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("TbBiography")]
    public class Biography:BaseEntity
    {
        public Biography()
        {

        }


        public string title { get; set; }

        public string Description { get; set; }

        public string imagePath { get; set; }

    }
}
