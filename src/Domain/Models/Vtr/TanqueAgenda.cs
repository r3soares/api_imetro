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
        public string Id { get; private set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Se houver bitrem, o mesmo será associado a agenda do outro veículo
        /// </summary>
        [JsonProperty]
        public TanqueAgenda BitremAgenda { get; set; }

        [JsonProperty]
        public DateTimeOffset Agenda { get; set; }

        [JsonProperty]
        public int Tanque { get; set; }

        [JsonProperty]
        public int StatusConfirmacao { get; set; }

        [JsonProperty]
        public int StatusPagamento { get; set; }

        [JsonProperty]
        public int Status { get; set; }

        [JsonProperty]
        public Empresa Responsavel { get; set; }

        [JsonProperty]
        public double CustoVerificacao { get; set; }

        [JsonProperty]
        public int TempoVerificacao { get; set; } //Em minutos
    }

}