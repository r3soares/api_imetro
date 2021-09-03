using Realms;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    public class Empresa : RealmObject
    {
        [PrimaryKey]
        public string Cnpj { get; set; }
        public int CodProprietario { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IList<string> TanquesAgendados { get; }
        public int Status { get; set; }
    }

}