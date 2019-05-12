using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Pagination;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;

        IUnitOfWork Database { get; set; }

        public ProductService(IUnitOfWork uow, IMapper mapper)
        {
            Database = uow;
            _mapper = mapper;
        }
        public async Task<Product> GetProductById(int id)
        {
            return await Database.Products.Get(id);
        }
        public IQueryable<Product> GetProductsByCategory(int id)
        {
            var products = Database.Products.GetProducts().Where(x => x.AmountInStock > 0);
            var productsWithRightCategory = products.Where(prod => prod.ProductCategotyId == id);
            return productsWithRightCategory;
        }
        public IQueryable<Product> GetAllProducts()
        {
            var products = Database.Products.GetProducts().Where(x => x.AmountInStock > 0);
            return products;
        }
        public IQueryable<Product> GetSortOrder(SortState sortState, SortOrder order, IQueryable<Product> products)
        {
            switch (sortState)
            {
                case SortState.Firm:
                    {
                        products = order == SortOrder.Asc
                              ? products.OrderBy(k => k.Supplier.CompanyName)
                              : products.OrderByDescending(k => k.Supplier.CompanyName);
                        break;
                    }
                case SortState.Price:
                    {
                        products = order == SortOrder.Asc
                            ? products.OrderBy(k => k.Price)
                            : products.OrderByDescending(k => k.Price);
                        break;
                    }

                default:
                    {
                        products = products.OrderBy(k => k.Price);
                        break;
                    }

            }
            return products;
        }

        public IQueryable<Product> FullTextSearch(string search)
        {
            return Database.Products.FullTextSearch(search);
        }
        public IQueryable<Product> FilterProducts(IQueryable<Product> products, string search)
        {
            var filtersProducts =
                products.Where(p => p.Title.Contains(search) || p.Supplier.CompanyName.Contains(search));
            return filtersProducts;
        }

        public async Task<HomeViewModel> AddPaginationSortingFiltering(IQueryable<Product> item, int page, int pageSize, SortState sortState, SortOrder sortOrder, string searchString)
        {
            var count = await item.CountAsync();
            var items = await item.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var productModel = _mapper.Map<List<Product>, List<ProductModel>>(items);

            Paginator paginator = new Paginator(count, page, pageSize);
            HomeViewModel viewModel = new HomeViewModel
            {
                PageViewModel = paginator,
                Items = productModel,
                SortModel = new SortModel(sortState, sortOrder),
                FilterModel = new FilterModel(searchString)
            };
            return viewModel;
        }

    }
}

