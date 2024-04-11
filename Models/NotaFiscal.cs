using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTelefonia.Models
{
    public class NotaFiscal
    {
        public int ID { get; set; }
        public string? Fornecedor { get; set; }
        public string? Cliente { get; set; }
        public string? NumeroNF { get; set; }
        public DateTime DataNF { get; set; }
        public int Soma { get; set; }
    }
}