using Newtonsoft.Json;
using Realms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Agenda : RealmObject
    { 
        [PrimaryKey]
        [JsonProperty]
        public string Data { get; set; }        
        [Indexed]
        public DateTimeOffset D { get; set; }

        [JsonProperty]
        public IList<TanqueAgendado> TanquesAgendados { get;}
        [JsonProperty]
        public int Status { get; set; }

        [JsonProperty]
        public string Obs { get; set; }
    }

}