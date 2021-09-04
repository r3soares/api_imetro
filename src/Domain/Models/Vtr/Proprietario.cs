using Newtonsoft.Json;
using Realms;
using System.Collections.Generic;

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
        public IList<int> Tanques { get;}
    }

}