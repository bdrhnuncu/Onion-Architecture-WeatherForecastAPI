﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class PharmacyOnDutyResponseResult
    {
        public string Name { get; set; }
        public string Dist { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Loc { get; set; }
    }
}
