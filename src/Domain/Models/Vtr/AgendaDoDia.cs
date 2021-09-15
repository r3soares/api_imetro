using Newtonsoft.Json;
using Realms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AgendaDoDia : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public DateTimeOffset Data { get; set; } //DD/MM/YYYY
        [JsonProperty]
        [Backlink(nameof(AgendaDoTanque.Agenda))]
        public IList<AgendaDoTanque> TanquesAgendados { get;}
        [JsonProperty]
        public int Status { get; set; }
    }

}