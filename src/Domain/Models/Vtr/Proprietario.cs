using Realms;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    public class Proprietario : RealmObject
    {
        [PrimaryKey]
        public int CodProprietario { get; set; }
        public int CodMunicipio { get; set; }
        public IList<int> Tanques { get;}
    }

}