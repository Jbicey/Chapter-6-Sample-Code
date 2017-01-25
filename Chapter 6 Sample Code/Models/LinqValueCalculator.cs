using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter_6_Sample_Code.Models;

namespace Chapter_6_Sample_Code.Models
{
    public class LinqValueCalculator :IValueCalculator 
    {
        public decimal ValueProducts (IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }      
    }
}