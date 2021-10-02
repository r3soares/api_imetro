using Newtonsoft.Json;
using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AgendaDoTanque : Realms.RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Se houver bitrem, o mesmo será associado a agenda do outro veículo
        /// </summary>
        [JsonProperty]
        public string BitremAgenda { get; set; }

        /// <summary>
        /// Agenda do dia
        /// </summary>
        [JsonProperty]
        public long TanqueAgendado { get; set; }

        [JsonProperty]
        public int Tanque { get; set; }

        [JsonProperty]
        public int StatusConfirmacao { get; set; }

        [JsonProperty]
        public int StatusPagamento { get; set; }

        [JsonProperty]
        public int Status { get; set; }

        [JsonProperty]
        public string Responsavel { get; set; }

        [JsonProperty]
        public double CustoVerificacao { get; set; }

        [JsonProperty]
        public int TempoVerificacao { get; set; } //Em minutos
    }

}