using Newtonsoft.Json;
using Realms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Empresa : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        [Realms.Required]
        public string Cnpj { get; set; }
        [JsonProperty]
        public Proprietario Proprietario { get; set; }
        [JsonProperty]
        public string Nome { get; set; }
        [JsonProperty]
        public IList<string> Telefones { get;}
        [JsonProperty]
        public string Email { get; set; }
        [JsonProperty]
        public int Status { get; set; }
    }

}