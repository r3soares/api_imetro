using Newtonsoft.Json;
using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CustoTanque : EmbeddedObject
    {
        [JsonProperty]
        public DateTimeOffset DataCalculo { get; set; }
        [JsonProperty]
        public double Custo { get; set; }
    }

}
