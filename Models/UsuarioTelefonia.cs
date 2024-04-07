using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTelefonia.Models
{
    public class UsuarioTelefonia
    {
        public int ID { get; set; }
        public string? Pessoa { get; set; }
        public string? DepartamentoPessoa { get; set; }
        public string? Telefone { get; set; }
        public string? ICCID { get; set; }
        public string? Operadora { get; set; }
        public string? InventarioAparelho { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}