using Newtonsoft.Json;
using Realms;
using System.Collections.Generic;
using System.Linq;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Proprietario : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public int CodProprietario { get; set; }

        [JsonProperty]
        public int CodMunicipio { get; set; }

        [JsonProperty]
        public Empresa Empresa { get; set; }

        [JsonProperty]
        [Backlink(nameof(Tanque.Proprietario))]
        public IQueryable<Tanque> Tanques { get;}
    }

}