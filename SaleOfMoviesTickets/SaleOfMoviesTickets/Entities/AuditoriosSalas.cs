using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfMoviesTickets.Entities
{
    public class AuditoriosSalas
    {
        public int AuditorioId { get; set; }
        public int SalaId { get; set; }
        public Auditorio Auditorio { get; set; }
        public Sala Sala { get; set; }
    }
}
