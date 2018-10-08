using System.ComponentModel.DataAnnotations;

namespace CesarWeb.Models
{
    public class CesarViewModel
    {
        [Required]
        public string Mensaje { get; set; }

        [Required]
        public int Clave { get; set; }
    }

}