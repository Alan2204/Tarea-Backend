using WebApiPc.Entidades;
using System.ComponentModel.DataAnnotations;

namespace WebApiPc
{
    public class Marca
    {
        public int Id { get; set; }
        public int ModeloID { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(maximumLength: 20, ErrorMessage = "El nombre del {0} solo puede tener hasta 20 caracteres")]
        public string Fabricante { get; set; }
        public string Procesador { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(maximumLength: 20, ErrorMessage = "El nombre del {0} solo puede tener hasta 20 caracteres")]
        public int Ram { get; set; }
        public string SO { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(maximumLength: 20, ErrorMessage = "El nombre del {0} solo puede tener hasta 20 caracteres")]
        public string Almacenamiento { get; set; }
        public  Computadora computadora { get; set; }     
    }
}
