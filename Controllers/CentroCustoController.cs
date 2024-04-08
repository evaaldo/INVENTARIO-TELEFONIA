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
    public class CentroCustoController : ControllerBase
    {
        private readonly InventarioTelefoniaContext _context;

        public CentroCustoController(InventarioTelefoniaContext context)
        {
            _context = context;
        }

        [HttpGet]   
        public IActionResult ListarCentrosCusto()
        {
            try
            {
                var centrosBanco = _context.CentrosCusto.ToList();

                return Ok(centrosBanco);
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}