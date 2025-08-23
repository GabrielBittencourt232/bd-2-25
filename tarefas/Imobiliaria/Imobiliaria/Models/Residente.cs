using System.ComponentModel.DataAnnotations;

namespace Imobiliaria.Models
{
    public class Residente
    {
        [Key]
        public int ResidenteID { get; set; }
        public string? Nome { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
