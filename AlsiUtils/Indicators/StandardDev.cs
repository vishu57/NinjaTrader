﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlsiUtils.Indicators
{
    public class StandardDev:Indicator
    {
        public int N { get; set; }       
        public double StdDev { get; set; }
        public double CustomValue { get; set; }
        public double SingleStdev { get; set; }
    }
}