using Realms;

namespace src.Domain.Models.Vtr
{
    public class Empresa : RealmObject
    {
        [PrimaryKey]
        public string Cnpj { get; set; }
        public int CodProprietario { get; set; }
    }

}