using Newtonsoft.Json;
using Realms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AgendaDoDia : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public long Data { get; set; } //DD/MM/YYYY
        [JsonProperty]
        public IList<string> TanquesAgendados { get;}
        [JsonProperty]
        public int Status { get; set; }
    }

}