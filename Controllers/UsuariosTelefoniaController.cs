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

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioTelefonia usuarioTelefonia)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Add(usuarioTelefonia);
                _context.SaveChanges();

                return Ok("Cadastro realizado com sucesso!");
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpGet("ConsultarUsuarios")]
        public IActionResult ConsultarUsuarios()
        {
            try
            {
                var usuarios = _context.UsuariosTelefonia.ToList();

                return Ok(usuarios);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpGet("{pessoa}")]
        public IActionResult ConsultarUsuarioPorNome(string pessoa)
        {
            try
            {
                var usuarioBanco = _context.UsuariosTelefonia.Where(usuario => usuario.Pessoa.Contains(pessoa)).ToList();

                if(usuarioBanco == null)
                {
                    return NotFound("Usuário não encontrado.");
                }

                return Ok(usuarioBanco);
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpGet("Ativos/{ativo}")]
        public IActionResult ConsultarUsuariosAtivos(bool ativo)
        {
            var usuariosBanco = _context.UsuariosTelefonia.Where(usuario => usuario.Ativo.Equals(ativo)).ToList();

            if(usuariosBanco == null)
            {
                return NotFound("Não existem usuários.");
            }

            return Ok(usuariosBanco);
        }

        [HttpPut]
        public IActionResult AtualizarUsuario(UsuarioTelefonia usuarioTelefonia)
        {
            try
            {
                var usuarioBanco = _context.UsuariosTelefonia.Find(usuarioTelefonia.ID);

                if(usuarioBanco == null)
                {
                    return NotFound("Usuário não encontrado.");
                }

                usuarioBanco.Pessoa = usuarioTelefonia.Pessoa;
                usuarioBanco.DepartamentoPessoa = usuarioTelefonia.DepartamentoPessoa;
                usuarioBanco.Telefone = usuarioTelefonia.Telefone;
                usuarioBanco.ICCID = usuarioTelefonia.ICCID;
                usuarioBanco.Operadora = usuarioTelefonia.Operadora;
                usuarioBanco.InventarioAparelho = usuarioTelefonia.InventarioAparelho;
                usuarioBanco.DataInicial = usuarioTelefonia.DataInicial;
                usuarioBanco.DataFinal = usuarioTelefonia.DataFinal;
                usuarioBanco.Ativo = usuarioTelefonia.Ativo;

                _context.UsuariosTelefonia.Update(usuarioBanco);
                _context.SaveChanges();

                return Ok("Alterações realizadas com sucesso!");
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            try
            {
                var usuarioBanco = _context.UsuariosTelefonia.Find(id);

                if(usuarioBanco == null)
                {
                    return NotFound("Usuário não encontrado.");
                }

                _context.UsuariosTelefonia.Remove(usuarioBanco);
                _context.SaveChanges();

                return Ok("Usuário removido com sucesso!");
            }
            catch(Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}