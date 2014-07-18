﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaApi.Models
{
    public class Equipment
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<DowntimeEvent> DowntimeEvents { get; set; }
    }
}