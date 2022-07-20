﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
