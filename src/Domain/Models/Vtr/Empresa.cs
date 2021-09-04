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
        public int CodProprietario { get; set; }
        [JsonProperty]
        public string Nome { get; set; }
        [JsonProperty]
        public string Telefone { get; set; }
        [JsonProperty]
        public string Email { get; set; }
        [JsonProperty]
        public IList<string> TanquesAgendados { get; }
        [JsonProperty]
        public int Status { get; set; }
    }

}