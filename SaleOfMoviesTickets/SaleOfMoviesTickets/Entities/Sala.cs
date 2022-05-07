using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfMoviesTickets.Entities
{
    public class Sala
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        public string Type { get; set; }
        public List<AuditoriosSalas> AuditoriosSalas { get; set; }
        public List<SalasButacas> SalasButacas { get; set; }
    }
}
