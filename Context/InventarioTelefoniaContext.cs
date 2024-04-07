using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventarioTelefonia.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioTelefonia.Context
{
    public class InventarioTelefoniaContext : DbContext
    {
        public InventarioTelefoniaContext(DbContextOptions<InventarioTelefoniaContext> options) : base(options)
        {
        }

        public DbSet<UsuarioTelefonia> UsuariosTelefonia { get; set; }
    }
}