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
    public class NotaFiscalController : ControllerBase
    {
        private readonly InventarioTelefoniaContext _context;

        public NotaFiscalController(InventarioTelefoniaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarNotaFiscal(NotaFiscal notaFiscal)
        {
            try
            {
                _context.NotasFiscais.Add(notaFiscal);
                _context.SaveChanges();

                return Ok("Nota fiscal adicionada com sucesso!");
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]   
        public IActionResult ConsultarNotasFiscais()
        {
            try
            {
                var notasBanco = _context.NotasFiscais.ToList();

                return Ok(notasBanco);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{numeroNF}")]
        public IActionResult ConsultarNotaFiscalPorNumero(string numeroNF)
        {
            try
            {
                var notaBanco = _context.NotasFiscais.Where(nota => nota.NumeroNF == numeroNF);

                if(notaBanco == null)
                {
                    return NotFound();
                }

                return Ok(notaBanco);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}