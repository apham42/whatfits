﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Interfaces
{
    interface IRetrieval
    {
        IResponseDTO Retrieve<T>(T obj);
    }
}
