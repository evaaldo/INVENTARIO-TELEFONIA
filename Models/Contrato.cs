using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTelefonia.Models
{
    public class Contrato
    {
        public int ID { get; set; }
        public string? Contratante { get; set; }
        public bool Contratado { get; set; }
        public string? NumeroContrato { get; set; }
        public string? ObjetoContrato { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string? TipoDocumento { get; set; }
    }
}