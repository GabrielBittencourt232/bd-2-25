using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Imobiliaria.Models
{
    public class Imovel
    {
        [Key]
        public int ImovelID { get; set; }
        public String? Nome { get; set; }

    }
}
