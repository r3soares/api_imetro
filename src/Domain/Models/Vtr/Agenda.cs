using Newtonsoft.Json;
using Realms;
using System.Collections;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Agenda : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Data { get; set; } //DD/MM/YYYY
        [JsonProperty]
        public IList<string> TanquesAgendados { get;}
        [JsonProperty]
        public int Status { get; set; }
    }

}