using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using EBooks.ViewModels.AccountViewModels;

namespace VapeShop.AutoMapper
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
