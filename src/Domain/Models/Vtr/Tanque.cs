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
        public int Proprietario { get; set; }
        [JsonProperty]
        public DateTimeOffset DataRegistro { get; set; }
        [JsonProperty]
        public DateTimeOffset DataUltimaAlteracao { get; set; }
        [JsonProperty]
        public string AgendaTanque { get; set; }
        [JsonProperty]
        public int Status { get; set; }
        [JsonProperty]
        public IList<CustoTanque> HistoricoCustos { get; set; }
        [JsonProperty]
        public IList<string> LinkDocs { get;}
    }

}