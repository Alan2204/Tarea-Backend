namespace WebApiPc.Entidades
{
    public class Computadora
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public List<Marca> Marca { get; set; }


    }
}
