﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlSugar.Utility.ApiResult
{
    public class ApiResult
    {
        public int Code { get; set; }
        public string msg { get; set; }
        public int Total { get; set; }
        public dynamic Data { get; set; }
    }
}
