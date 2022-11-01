using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace src.Domain.Models.Vtr
{
    [ValidateNever]
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

        //[JsonProperty]
        public long StatusConfirmacao => StatusGenerico.Count > 0 ? StatusGenerico[0] : -1;

        //[JsonProperty]
        public long StatusPagamento => StatusGenerico.Count > 1 ? StatusGenerico[1] : -1;

        [JsonProperty]
        public IList<long> StatusGenerico { get;}

        [JsonProperty]
        public string AgendaAnterior { get; set; }

        [JsonProperty]
        public Responsavel Responsavel { get; set; }

        //private IDictionary<string, string> responsavel { get; }

        //[JsonProperty]
        //public Responsavel Responsavel 
        //{
        //    get
        //    {
        //        if (!responsavel.Any())
        //            return null;

        //        var r = new Responsavel()
        //        {
        //            Apelido = responsavel["apelido"],
        //            ApelidoEmpresa = responsavel["apelidoEmpresa"],
        //            CNPJ_CPF = responsavel["cnpj_cpf"],
        //            ID = responsavel["id"],
        //            Obs = responsavel["obs"],
        //        };

        //        var emails = responsavel["emails"].Split(";");
        //        foreach (var i in emails)
        //        {
        //            r.Emails.Add(i);
        //        }
        //        var telefones = responsavel["telefones"].Split(";");
        //        foreach (var i in telefones)
        //        {
        //            r.Telefones.Add(i);
        //        }

        //        return r;
        //    }
        //    set
        //    {
        //        responsavel["apelido"] = value.Apelido;
        //        responsavel["apelidoEmpresa"] = value.ApelidoEmpresa;
        //        responsavel["cnpj_cpf"] = value.CNPJ_CPF;
        //        responsavel["id"] = value.ID;
        //        responsavel["obs"] = value.Obs;
        //        responsavel["emails"] = String.Join(';', value.Emails);
        //        responsavel["telefones"] = String.Join(';', value.Telefones);
        //    }
        //}

        [JsonProperty]
        public double CustoVerificacao { get; set; }

        [JsonProperty]
        public int TempoVerificacao { get; set; } //Em minutos

        [JsonProperty]
        public string Obs { get; set; }
    }

}