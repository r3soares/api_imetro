using Newtonsoft.Json;
using Realms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Agenda : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public DateTimeOffset Data { get; set; } //DD/MM/YYYY
        [JsonProperty]
        public IList<TanqueAgenda> TanquesAgendados { get;}
        [JsonProperty]
        public int Status { get; set; }
    }

}