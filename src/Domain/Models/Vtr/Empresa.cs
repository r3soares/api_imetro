using Newtonsoft.Json;
using Realms;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Empresa : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Cnpj { get; set; }
        [JsonProperty]
        public Proprietario Proprietario { get; set; }
        [JsonProperty]
        public string Nome { get; set; }
        [JsonProperty]
        public List<string> Telefone { get;}
        [JsonProperty]
        public List<string> Email { get;}
        [JsonProperty]
        public int Status { get; set; }
    }

}