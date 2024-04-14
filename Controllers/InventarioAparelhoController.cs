using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioTelefonia.Context;
using InventarioTelefonia.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventarioTelefonia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventarioAparelhoController : ControllerBase
    {
        private readonly InventarioTelefoniaContext _context;

        public InventarioAparelhoController(InventarioTelefoniaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarAparelho(InventarioAparelho aparelho)
        {
            try
            {
                
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        public IActionResult ListarAparelhos()
        {
            try
            {
                var aparelhosBanco = _context.InventariosAparelho.ToList();

                return Ok(aparelhosBanco);
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{numeroSerie}")]
        public IActionResult BuscarAparelhoPorNumeroSerie(string numeroSerie)
        {
            try
            {

            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{ativo}")]
        public IActionResult FiltrarAparelhosAtivos(bool ativo)
        {
            try
            {

            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        public IActionResult EditarAparelho(InventarioAparelho aparelho)
        {
            try
            {

            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverAparelho(int id)
        {
            try
            {

            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}