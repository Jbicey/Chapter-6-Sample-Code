using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter_6_Sample_Code.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}