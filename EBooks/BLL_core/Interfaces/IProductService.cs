using BLL_core.Pagination;
using DAL_core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_core.Interfaces
{
    public interface IProductService
    {
        IQueryable<Product> GetProductsByCategory(int id);
        IQueryable<Product> GetSortOrder(SortState sortState, SortOrder order,
            IQueryable<Product> products);
        IQueryable<Product> FilterProducts(IQueryable<Product> products, string search);
        //Task<HomeViewModel> AddPagination(IQueryable<Product> item, int page, int pageSize);
        Task<HomeViewModel> AddPaginationSortingFiltering(IQueryable<Product> item, int page, int pageSize,
            SortState sortState, SortOrder sortOrder, string searchString);
        IQueryable<Product> GetAllProducts();
        IQueryable<Product> FullTextSearch(string search);
        Task<Product> GetProductById(int id);
    }
}
