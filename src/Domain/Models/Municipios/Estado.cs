using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Municipios
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class Estado : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public int UnfId { get; set; }
        [JsonProperty]
        public string SgUf { get; set; }
        [JsonProperty]
        public string NoUf { get; set; }
    }
}
