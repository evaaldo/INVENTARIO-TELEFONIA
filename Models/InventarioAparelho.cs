using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTelefonia.Models
{
    public class InventarioAparelho
    {
        public int ID { get; set; }
        public string? ModeloAparelho { get; set; }
        public DateTime DataAquisicao { get; set; }
        public DateTime DataDesativacao { get; set; }
        public string? NumeroSerie { get; set; }
        public string? Modalidade { get; set; }
        public string? Mantenedora { get; set; }
        public bool Disponivel { get; set; }
    }
}