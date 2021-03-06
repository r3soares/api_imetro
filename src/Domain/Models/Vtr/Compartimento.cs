using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;

namespace src.Domain.Models.Vtr
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class Compartimento : Realms.EmbeddedObject
    {
        [JsonProperty]
        public int Pos { get; set; }

        [JsonProperty]
        public int Cap { get; set; }

        [JsonProperty]
        public int Setas { get; set; }

        [JsonProperty]
        public string Obs { get; set; }
    }

}