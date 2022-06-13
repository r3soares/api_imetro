using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;
using System;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class Agenda : RealmObject
    {
        [PrimaryKey]
        [JsonProperty]
        public string Data { get; set; }
        [Indexed]
        public DateTimeOffset D { get; set; }

        [JsonProperty]
        public IList<TanqueAgendado> TanquesAgendados { get; }
        [JsonProperty]
        public int Status { get; set; }

        [JsonProperty]
        public string Obs { get; set; }
    }

}