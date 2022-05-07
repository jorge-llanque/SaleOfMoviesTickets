using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfMoviesTickets.Entities
{
    public class SalasButacas
    {
        public int SalaId { get; set; }
        public int ButacaId { get; set; }
        public Butaca Butaca { get; set; }
        public Sala Sala { get; set; }
    }
}
