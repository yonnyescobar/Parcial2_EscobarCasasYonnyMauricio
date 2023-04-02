using System;
using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Entity
    {
        #region porperties
        [Key]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Número de boleta")]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de uso")]
        public DateTime? UseDate { get; set; }
        #endregion
    }
}