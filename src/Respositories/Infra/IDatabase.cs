﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra
{
    public interface IDatabase
    {
        public IConnection Connection { get; init; }
    }
}
