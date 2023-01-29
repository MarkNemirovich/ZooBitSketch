﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooBitSketch
{
    internal interface IPayable
    {
        public int CheckAmount(Currency currency);
        public bool Pay(Currency currency, int cost);
    }
}