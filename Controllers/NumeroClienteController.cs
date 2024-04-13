using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioTelefonia.Context;
using Microsoft.AspNetCore.Mvc;

namespace InventarioTelefonia.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NumeroClienteController : ControllerBase
    {
        private readonly InventarioTelefoniaContext _context;

        public NumeroClienteController(InventarioTelefoniaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ListarNumerosClientes()
        {
            try
            {
                var numerosClientes = _context.NumerosClientes.ToList();

                return Ok(numerosClientes)
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{numero}")]
        public IActionResult BuscarNumeroCliente(string numero)
        {
            try
            {
                var numeroCliente = _context.NumerosClientes.Where(num => num.Numero.Contains(numero));

                if(numeroCliente == null)
                {
                    return NotFound();
                }

                return Ok(numeroCliente);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        public IActionResult AdicionarNumeroCliente()
        {
            try
            {

            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        public IActionResult EditarNumeroCliente()
        {
            try
            {

            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        public IActionResult RemoverNumeroCliente()
        {
            try
            {

            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}