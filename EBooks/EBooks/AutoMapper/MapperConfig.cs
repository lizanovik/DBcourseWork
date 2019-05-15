using AutoMapper;
using BLL_core.DTO;
using DAL_core.Entities;
using EBooks.ViewModels.AccountViewModels;

namespace EBooks.AutoMapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            ProductMapping();
            AccountMapping();
            OrderMapping();
            AddProductMapping();
            AddSupplierMapping();
        }

        private void ProductMapping()
        {
            CreateMap<Product, ProductModel>();
        }

        private void AccountMapping()
        {
            CreateMap<RegisterViewModel, UserModel>();
        }
        private void OrderMapping()
        {
            CreateMap<Order, OrderModel>();
        }

        private void AddProductMapping()
        {
            CreateMap<AddProductModel, Product>();
        }

        private void AddSupplierMapping()
        {
            CreateMap<AddSupplierModel, Supplier>();
        }

    }
}
