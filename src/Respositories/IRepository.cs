using Realms;
using src.Respositories.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories
{
    public interface IRepository
    { 
        public IDatabase Database { get; init; }
    }
}
