using System.ComponentModel.DataAnnotations;

namespace Concert.DAL.Entities
{
    public class Ticket
    {
        #region
        [Key]
        public virtual Guid Id { get; set; }
        
        [Display(Name = "Fecha de uso")]
        public virtual DateTime? UseDate { get; set; }

        [Display(Name = "¿Esta en uso?")]
        public bool? IsUsed { get; set; }

        [Display(Name = "Puerta de entrada")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe de tener minimo {1} caracter")]
        public string? EntranceGate { get; set; }
        #endregion


    }
}
