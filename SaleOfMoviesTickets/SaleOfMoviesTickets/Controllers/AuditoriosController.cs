using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleOfMoviesTickets.DTOs;
using SaleOfMoviesTickets.Entities;

namespace SaleOfMoviesTickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoriosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AuditoriosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Auditorio>>> Get()
        {
            return context.Auditorios.ToList();
        }
        [HttpGet("{id:int}", Name = "obtenerAuditorio")]
        public async Task<ActionResult<AuditorioDTO>> Get(int id)
        {
            var entidad = await context.Auditorios.FirstOrDefaultAsync(x => x.Id == id);
            if (entidad == null)
            {
                return NotFound();
            }

            var dto = mapper.Map<AuditorioDTO>(entidad);
            return dto;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AuditorioCreacionDTO auditorioCreacionDTO)
        {
            var entidad = mapper.Map<Auditorio>(auditorioCreacionDTO);
            context.Add(entidad);
            await context.SaveChangesAsync();

            var auditorioDTO = mapper.Map<AuditorioDTO>(entidad);
            return new CreatedAtRouteResult("obtenerAuditorio", new { id = auditorioDTO.Id }, auditorioDTO);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Auditorios.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Auditorio() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
