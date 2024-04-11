using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioTelefonia.Context;
using Microsoft.AspNetCore.Mvc;

namespace InventarioTelefonia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContratoController : ControllerBase
    {
        private readonly InventarioTelefoniaContext _context;
        public ContratoController(InventarioTelefoniaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ListarContratos()
        {
            try
            {
                var contratosBanco = _context.Contratos.ToList();

                return Ok(contratosBanco);
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarContratoPorID(int id)
        {
            try
            {
                var contratoBanco = _context.Contratos.Where(contrato => contrato.ID == id);

                if(contratoBanco == null)
                {
                    return NotFound();
                }

                return Ok(contratoBanco);
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public IActionResult AdicionarContrato()
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
        public IActionResult EditarContrato()
        {
            try
            {

            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete]
        public IActionResult RemoverContrato()
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