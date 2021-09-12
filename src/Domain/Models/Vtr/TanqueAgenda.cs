using Newtonsoft.Json;
using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TanqueAgenda : Realms.RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Id { get; private set; }
        [JsonProperty]
        public DateTimeOffset Agenda { get; set; }
        [JsonProperty]
        public int Tanque { get; set; }
        [JsonProperty]
        public int StatusConfirmacao { get; set; }
        [JsonProperty]
        public int StatusPagamento { get; set; }
        [JsonProperty]
        public string Responsavel { get; set; }
        [JsonProperty]
        public double CustoVerificacao { get; set; }
        [JsonProperty]
        public int TempoVerificacao { get; set; } //Em minutos

        public void GeraKey()
        {
            Id = Tanque + Agenda.ToString("ddMMyyyy");
        }
    }

}