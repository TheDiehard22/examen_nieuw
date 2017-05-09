using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_ToolsForEver.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        public string Naam { get; set; }

        public string Type { get; set; }

        public decimal InkoopPrijs { get; set; }

        public decimal VerkoopPrijs { get; set; }

        public int MinVoorraad { get; set; }

        public int ProductLocationID { get; set; }
        public IEnumerable<ProductLocation> ProductLocations { get; set; }
    }
}
