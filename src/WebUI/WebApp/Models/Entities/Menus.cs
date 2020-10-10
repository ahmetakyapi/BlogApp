using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Entities
{
    [Table("tbMenus")]
    public class Menus:BaseEntity
    {

        public Menus()
        {
            
        }

        public string name { get; set; }
    }
}
