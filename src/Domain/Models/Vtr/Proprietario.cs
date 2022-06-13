using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Vtr
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class Proprietario : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public int Cod { get; set; }

        [JsonProperty]
        public int CodMun { get; set; }

    }

}