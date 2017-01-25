using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter_6_Sample_Code.Models;

namespace Chapter_6_Sample_Code.Models
{
        public class Product
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
        }
    }