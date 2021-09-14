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
        public int CodInmetro { get; set; }
        [JsonProperty]
        [Indexed]
        public string Placa { get; set; }
        [JsonProperty]
        public IList<Compartimento> Compartimentos { get; }
        [JsonProperty]
        public Proprietario Proprietario { get; set; }
        [JsonProperty]
        public DateTimeOffset DataRegistro { get; set; }
        [JsonProperty]
        public DateTimeOffset DataUltimaAlteracao { get; set; }
        [JsonProperty]
        public TanqueAgenda TanqueAgendado { get; set; }
        [JsonProperty]
        public int Status { get; set; }
        [JsonProperty]
        public double Custo { get; set; }
        [JsonProperty]
        public IList<string> LinkDocs { get;}
    }

}