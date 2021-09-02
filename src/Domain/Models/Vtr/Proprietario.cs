using Realms;

namespace src.Domain.Models.Vtr
{
    public class Proprietario : RealmObject
    {
        [PrimaryKey]
        public int CodProprietario { get; set; }
    }

}