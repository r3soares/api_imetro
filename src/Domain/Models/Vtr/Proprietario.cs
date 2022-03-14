using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Vtr
{
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