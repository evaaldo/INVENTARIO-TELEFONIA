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
    public class UsuariosTelefoniaController : ControllerBase
    {
        private readonly InventarioTelefoniaContext _context;

        public UsuariosTelefoniaController(InventarioTelefoniaContext context)
        {
            _context = context;
        }

        [HttpGet("ConsultarUsuarios")]
        public IActionResult ConsultarUsuarios()
        {
            var usuarios = _context.UsuariosTelefonia.ToList();

            return Ok(usuarios);
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioTelefonia usuarioTelefonia)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Add(usuarioTelefonia);
            _context.SaveChanges();

            return Ok("Cadastro realizado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            var usuarioBanco = _context.UsuariosTelefonia.Find(id);

            if(usuarioBanco == null)
            {
                return NotFound();
            }

            _context.UsuariosTelefonia.Remove(usuarioBanco);
            _context.SaveChanges();

            return Ok(usuarioBanco);
        }
    }
}