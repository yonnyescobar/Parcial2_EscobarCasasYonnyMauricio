using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConcertDB.DAL.Entities
{
    public class Ticket : Entity
    {
        #region properties
        [Display(Name = "Estado")]
        [DefaultValue(false)]
        public bool IsUsed { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Display(Name = "Portería de entrada")]
        public string? EntranceGate { get; set; }
        #endregion
    }
}

