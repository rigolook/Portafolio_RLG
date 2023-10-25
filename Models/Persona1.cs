using System.ComponentModel.DataAnnotations;

namespace Portafolio_RLG.Models
{
    public class Persona1
    {
        public int IDpersona { get; set; }
        public string Nombre { get; set; }
        public string Descripcionfullstack { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
      
        public string Pais { get; set; }
        
        public string Ciudad { get; set; }
    }
}
