using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MBuildingWeb.Domain
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; }
        public virtual IEnumerable<Product> Product { get; set; } = new List<Product>();
    }
}
