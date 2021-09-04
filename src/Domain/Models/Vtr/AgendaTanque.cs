using Newtonsoft.Json;
using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AgendaTanque : Realms.RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty]
        public string Agenda { get; set; }
        [JsonProperty]
        public int Tanque { get; set; }
        [JsonProperty]
        public int StatusConfirmacao { get; set; }
        [JsonProperty]
        public int StatusPagamento { get; set; }
        [JsonProperty]
        public string Responsavel { get; set; }
    }

}