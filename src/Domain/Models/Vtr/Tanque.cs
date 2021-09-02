using System.Collections.Generic;
using Realms;

namespace src.Domain.Models.Vtr
{
    public class Tanque : RealmObject
    {
        [PrimaryKey]
        public int CodInmetro { get; set; }
        [Indexed]
        public string Placa { get; set; }

        public IList<Compartimento> Compartimentos { get; }
    }

}