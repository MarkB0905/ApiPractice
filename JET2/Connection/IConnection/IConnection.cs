﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET2.Connection.IConnection
{

    public interface IConnection
    {
        Task<DataSet> RunProcedure(string procedure, List<DbParam> dBParamList);
        Task<DataSet> RunProcedure(string procedure);


    }

}

