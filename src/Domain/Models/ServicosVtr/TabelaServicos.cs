using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.ServicosVtr
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class TabelaServicos : RealmObject
    {
        [JsonProperty]
        [PrimaryKey]
        public string ID { get; set;}
        [JsonProperty]
        public string Nome { get; set; }
        [JsonProperty]
        public IList<ServicoVtr> Servicos { get; }
        [JsonProperty]
        public bool IsAtual { get; set; }
        [JsonProperty]
        public DateTimeOffset Data { get; set; }
    }
}