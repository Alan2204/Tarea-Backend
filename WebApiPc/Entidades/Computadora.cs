
using System.ComponentModel.DataAnnotations;


namespace WebApiPc.Entidades
{
    public class Computadora
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength (maximumLength: 20, ErrorMessage = "El nombre del {0} solo puede tener hasta 20 caracteres")]
        public string Modelo { get; set; }  
        


    }
}
