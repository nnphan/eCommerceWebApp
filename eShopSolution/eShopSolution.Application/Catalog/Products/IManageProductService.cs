using eShopSolution.Application.Catalog.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Manage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        //return product id
        Task<int> Create(ProductCreateRequest request);

        Task<int> Edit(ProductEditRequest request );

        Task<int> Delete(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

        Task<bool> UpdatePrice(int productId, decimal price);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
    }
}
