using eShopSolution.Application.Catalog.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Manage;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public int CategoryId { get; set; }

        public PagedResult<ProductViewModel> GetAllByCategoryId(Dtos.Public.GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
