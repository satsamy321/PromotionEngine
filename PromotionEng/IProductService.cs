using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEng
{
    public interface IProductService
    {
        Product GetPriceByType(string id);
        int GetTotalPrice(List<Product> products);
    }
}
