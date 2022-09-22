using WebApiPc.Entidades;

namespace WebApiPc
{
    public class Marca
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Procesador { get; set; }
        public int Ram { get; set; }
        public string SO { get; set; }
        public string Almacenamiento { get; set; }
        public Computadora computadora { get; set; }

        
    }
}
