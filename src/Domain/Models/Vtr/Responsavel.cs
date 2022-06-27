using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Vtr
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class Responsavel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [JsonProperty]
        public string ID { get; set; }
        [Indexed]
        [JsonProperty]
        public string Apelido { get; set; }
        [JsonProperty]
        public IList<string> Telefones { get; }
        [JsonProperty]
        public IList<string> Emails { get; }
        [JsonProperty]
        public string ApelidoEmpresa { get; set; }
        [JsonProperty]
        public string CNPJ_CPF { get; set; }
        [JsonProperty]
        public string Obs { get; set; }

        public static string GetNovoID => Guid.NewGuid().ToString();
    }
}