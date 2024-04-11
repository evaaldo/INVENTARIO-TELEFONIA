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
        public IActionResult AdicionarContrato(Contrato contrato)
        {
            try
            {
                _context.Contratos.Add(contrato);
                _context.SaveChanges();

                return Ok("Seu contrato foi adicionado com sucesso!");
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        public IActionResult EditarContrato(Contrato contrato)
        {
            try
            {
                var contratoBanco = _context.Contratos.Find(contrato.ID);

                if(contratoBanco == null)
                {
                    return NotFound();
                }

                contratoBanco.TipoDocumento = contrato.TipoDocumento;
                contratoBanco.Contratante = contrato.Contratante;
                contratoBanco.Contratado = contrato.Contratado;
                contratoBanco.NumeroContrato = contrato.NumeroContrato;
                contratoBanco.ObjetoContrato = contrato.ObjetoContrato;
                contratoBanco.DataFinal = contrato.DataFinal;
                contratoBanco.DataFinal = contrato.DataFinal;

                _context.Update(contratoBanco);
                _context.SaveChanges();

                return Ok("O contrato foi modificado com sucesso!");
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverContrato(int id)
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