using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioTelefonia.Context;
using InventarioTelefonia.Models;
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

        [HttpPost]
        public IActionResult AdicionarNumeroCliente(NumeroCliente numeroCliente)
        {
            try
            {
                _context.NumerosClientes.Add(numeroCliente);
                _context.SaveChanges();

                return Ok("Número do cliente salvo com sucesso!");
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        public IActionResult EditarNumeroCliente(NumeroCliente numeroCliente)
        {
            try
            {
                var numeroBanco = _context.NumerosClientes.Find(numeroCliente.ID);

                if(numeroBanco == null)
                {
                    return NotFound();
                }

                numeroBanco.Numero = numeroCliente.Numero;
                numeroBanco.Operadora = numeroCliente.Operadora;
                numeroBanco.Departamento = numeroCliente.Departamento;
                numeroBanco.DataAtivacao = numeroCliente.DataAtivacao;
                numeroBanco.DataDesativacao = numeroCliente.DataDesativacao;
                numeroBanco.Virtual = numeroCliente.Virtual;

                _context.NumerosClientes.Update(numeroBanco);
                _context.SaveChanges();

                return Ok("Número do cliente atualizado com sucesso!");
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverNumeroCliente(int id)
        {
            try
            {
                var numeroCliente = _context.NumerosClientes.Find(id);

                if(numeroCliente == null)
                {
                    return NotFound();
                }

                return Ok("Número removido com suceso!");
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}