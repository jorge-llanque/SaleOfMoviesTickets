﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleOfMoviesTickets.DTOs
{
    public class AuditorioCreacionDTO
    {
        [Required]
        [StringLength(300)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
