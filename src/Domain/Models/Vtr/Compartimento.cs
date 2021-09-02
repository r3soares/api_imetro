namespace src.Domain.Models.Vtr
{
    public class Compartimento : Realms.EmbeddedObject
    {
        public int Capacidade { get; set; }
        public int Setas { get; set; }
    }

}