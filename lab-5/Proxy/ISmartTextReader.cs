﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal interface ISmartTextReader
    {
        public char[][] ReadFile(string filename);
    }
}
