﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotin_lab_4.Models
{
    internal class RomanNumberExtend : RomanNumber
    {
        public RomanNumberExtend(string number) : base((ushort)RomanToInt(number)) { }

    }

}
