
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.ServicosVtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ServicoVtr : EmbeddedObject
    {
        [JsonProperty]
        public int Cod { get; set; }
        [JsonProperty]
        public int CapacidadeMaxima { get; set; }
        [JsonProperty]
        public double Valor { get; set; }
        [JsonProperty]
        public string Descricao { get; set; }
    }
}