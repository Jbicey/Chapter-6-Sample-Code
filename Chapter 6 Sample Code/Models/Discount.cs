using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter_6_Sample_Code.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
    public class DefaultDiscountHelper : IDiscountHelper
    {

        public decimal DiscountSize; public DefaultDiscountHelper(decimal discountParam)
        {
            DiscountSize = discountParam;
        }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize /100m * totalParam));
        }
    }
}