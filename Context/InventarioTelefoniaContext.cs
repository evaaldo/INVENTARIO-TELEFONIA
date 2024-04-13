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
        public InventarioTelefoniaContext(DbContextOptions<InventarioTelefoniaContext> options) : base(options) {}

        public DbSet<UsuarioTelefonia> UsuariosTelefonia { get; set; }
        public DbSet<CentroCusto> CentrosCusto { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<NumeroCliente> NumerosClientes { get; set; }
    }
}