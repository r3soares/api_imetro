using Newtonsoft.Json;
using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AgendaTanque : Realms.RealmObject
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
        public string Agenda { get; set; }

        [JsonProperty]
        public string Tanque { get; set; }

        [JsonProperty]
        public int StatusConfirmacao { get; set; }

        [JsonProperty]
        public int StatusPagamento { get; set; }

        [JsonProperty]
        public string AgendaAnterior { get; set; }

        [JsonProperty]
        public string Responsavel { get; set; }

        [JsonProperty]
        public double CustoVerificacao { get; set; }

        [JsonProperty]
        public int TempoVerificacao { get; set; } //Em minutos

        [JsonProperty]
        public string Obs { get; set; }
    }

}