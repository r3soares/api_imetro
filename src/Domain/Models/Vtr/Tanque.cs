using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Tanque : RealmObject
    {
        [JsonProperty]
        [PrimaryKey] 
        [Required]
        public string CodInmetro { get; set; }
        [JsonProperty]
        [Indexed]
        public string Placa { get; set; }
        [JsonProperty]
        public IList<Compartimento> Compartimentos { get; }
        [JsonProperty]
        public string Proprietario { get; set; }
        [JsonProperty]
        public DateTimeOffset DataRegistro { get; set; }
        [JsonProperty]
        public DateTimeOffset DataUltimaAlteracao { get; set; }
        [JsonProperty]
        public AgendaDoTanque TanqueAgendado { get; set; }
        [JsonProperty]
        public int Status { get; set; }
        [JsonProperty]
        public IList<string> LinkDocs { get;}
    }

}