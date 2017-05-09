using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_ToolsForEver.Models
{
    public class ProductLocation
    {
        [Key]
        public int ID { get; set; }

        public int LocationID { get; set; }

        public int ProductID { get; set; }
        
        [Required]
        public int aantal { get; set; }

        public int MinVoorraad { get; set; }

        public IEnumerable<Location> Locations { get; set; }
    }
}
