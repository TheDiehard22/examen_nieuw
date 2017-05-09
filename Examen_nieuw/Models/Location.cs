using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_ToolsForEver.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }

        public string LocationName { get; set; }
    }
}
