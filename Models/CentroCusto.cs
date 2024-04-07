using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTelefonia.Models
{
    public class CentroCusto
    {
        public int ID { get; set;}
        public string Cliente { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Conta { get; set; }
        public string ClasseValor { get; set; }
        public bool Ativo { get; set; }
    }
}