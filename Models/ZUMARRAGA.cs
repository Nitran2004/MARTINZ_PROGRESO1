using System.ComponentModel.DataAnnotations;

namespace MZ_PROGRESO1.Models
{
    public class ZUMARRAGA
    {
        [Required(ErrorMessage = "Escriba el codigo.")]
        //[RegularExpression("^[0-9]{9}-[0-9]{1}$", ErrorMessage = "Escriba un codigo valido.")]
        [Key]
        public int mzCodigo { get; set; }

        [Required(ErrorMessage = "Escriba la calificacion final.")]
        [Range(0.01, 10.0)]
        public decimal mzCalificacionFinal { get; set; }

        [Required(ErrorMessage = "Escriba el nombre y apellido.")]
        [MinLength(5, ErrorMessage = "Escriba al menos 5 caractéres.")]
        [MaxLength(50, ErrorMessage = "Escriba un máximo de 5 caractéres.")]
        public string? mzNombre { get; set; }

        [Required(ErrorMessage = "Escriba el nombre y apellido.")]
        [MinLength(5, ErrorMessage = "Escriba al menos 5 caractéres.")]
        [MaxLength(50, ErrorMessage = "Escriba un máximo de 5 caractéres.")]
        public string? mzApellido { get; set; }

        [Required(ErrorMessage = "Escriba el correo.")]
        [EmailAddress(ErrorMessage = "Escriba un correo válido.")]
        public string? mzCorreo { get; set; }

        [Required(ErrorMessage = "Escriba el codigo postal.")]
        public string? mzCodigoPostal { get; set; }

        public bool mzEstudianteNuevo { get; set; }

        [Required(ErrorMessage = "Escriba la fecha de nacimiento.")]
        public DateTime mzFechaNacimiento { get; set; }

        [Required(ErrorMessage = "Escriba la calificacion final.")]
        [Range(0.01, 5.0)]
        public float mzPromedioConducta { get; set; }
    }
}
