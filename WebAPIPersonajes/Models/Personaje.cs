using System.ComponentModel.DataAnnotations;

namespace WebAPIPersonajes.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El nombre de la pizza debe tener entre 3 y 100 caracteres.", MinimumLength = 2)]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "La fuerza debe estar entre 0 y 100.")]
        public int Force { get; set; }
        [Range(0, 200, ErrorMessage = "La altura debe estar entre 0 y 200.")]
        public int Hight { get; set; }
        public bool canFly { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
