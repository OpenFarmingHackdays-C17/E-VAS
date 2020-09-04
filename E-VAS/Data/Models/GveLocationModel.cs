﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Data.Models
{
    public class GveLocationModel
    {
        [Key]
        public int Id { get; set; }
        public GveModel Gve { get; set; }
        public string Coordinates { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
