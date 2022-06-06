using Newtonsoft.Json;
using Realms;
using System;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TanqueAgendado : Realms.RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonProperty]
        public DateTimeOffset DataRegistro { get; set; }

        [JsonProperty]
        public DateTimeOffset? DataInicio { get; set; }

        [JsonProperty]
        public DateTimeOffset? DataFim { get; set; }

        /// <summary>
        /// Se houver bitrem, o mesmo será associado a agenda do outro veículo
        /// </summary>
        [JsonProperty]
        public string BitremAgenda { get; set; }

        /// <summary>
        /// Tanque Zero
        /// </summary>
        [JsonProperty]
        public bool IsNovo { get; set; }

        /// <summary>
        /// Agenda do dia
        /// </summary>
        [JsonProperty]
        public string Agenda { get; set; }

        [JsonProperty]
        public Tanque Tanque { get; set; }

        [JsonProperty]
        public int StatusConfirmacao => StatusGenerico[0];

        [JsonProperty]
        public int StatusPagamento => StatusGenerico[1];

        [JsonProperty]
        public IList<int> StatusGenerico { get;} = new List<int>(new int[] { 0, 0, 0 });

        [JsonProperty]
        public string AgendaAnterior { get; set; }

        [JsonProperty]
        public Empresa Responsavel { get; set; }

        [JsonProperty]
        public double CustoVerificacao { get; set; }

        [JsonProperty]
        public int TempoVerificacao { get; set; } //Em minutos

        [JsonProperty]
        public string Obs { get; set; }
    }

}