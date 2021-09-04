using Newtonsoft.Json;
using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CustoTanque : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        [JsonProperty]
        public int Tanque { get; set; }
        [JsonProperty]
        public DateTimeOffset DataCalculo { get; set; }
        [JsonProperty]
        public double Custo { get; set; }
    }

}
