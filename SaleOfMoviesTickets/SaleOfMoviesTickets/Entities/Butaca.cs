using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfMoviesTickets.Entities
{
    public class Butaca
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        public List<SalasButacas> SalasButacas { get; set; }
    }
}
