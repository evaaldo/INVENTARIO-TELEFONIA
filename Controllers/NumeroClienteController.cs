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
    }
}