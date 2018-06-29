using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Examen.Entidades
{
    public partial class DatosPersona
    {   
        [DisplayName("Nombre")]
        [RegularExpression("[-A-Za-z0-9ñáéíóúÑÁÉÍÓÚ -]+", ErrorMessage = "Solo se permite letras y espacios en blanco")]
        public string nombre { get; set; }
  
        [DisplayName("Apellido Paterno")]
        [RegularExpression("[-A-Za-z0-9ñáéíóúÑÁÉÍÓÚ -]+", ErrorMessage = "Solo se permite letras y espacios en blanco")]
        public string aPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        [RegularExpression("[-A-Za-z0-9ñáéíóúÑÁÉÍÓÚ -]+", ErrorMessage = "Solo se permite letras y números")]
        public string aMaterno { get; set; }
 
        [DisplayName("CURP")]
        [RegularExpression("[A-Za-z0-9ñáéíóúÑÁÉÍÓÚ -]+", ErrorMessage = "Solo se permite letras y espacios en blanco")]
        public string curp { get; set; }
    }
}
