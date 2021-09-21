﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Service(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
