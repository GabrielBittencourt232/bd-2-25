using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.Models
{
    [PrimaryKey(nameof(ResidenteID), nameof(ImovelID))]
    public class ResidenteImovel
    {
        
        public int ResidenteID { get; set; }
        [ForeignKey(nameof(ResidenteID))]
        public Residente? Residente { get; set; }


        public int ImovelID { get; set; }
        [ForeignKey(nameof(ImovelID))]
        public Imovel? Imovel { get; set; }
    }
}
