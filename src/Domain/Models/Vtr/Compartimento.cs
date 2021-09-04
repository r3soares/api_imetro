using Newtonsoft.Json;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Compartimento : Realms.EmbeddedObject
    {
        [JsonProperty]
        public int Capacidade { get; set; }
        [JsonProperty]
        public int Setas { get; set; }
    }

}