﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyEuroleague.Enumerations
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Position
    {
        Guard,
        Forward,
        Center
    }
}