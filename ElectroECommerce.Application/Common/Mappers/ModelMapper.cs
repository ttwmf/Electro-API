using AutoMapper;
using ElectroECommerce.Application.Models.Dtos;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Common.Mappers
{
    public static class ModelMapper
    {
        public static void MappingDto(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Product, DtoProduct>();
            cfg.CreateMap<Supplier, DtoSupplier>();
            cfg.CreateMap<Specifications, DtoSpecifications>();
            cfg.CreateMap<OrderDetail, DtoOrderDetail>();
            cfg.CreateMap<Customer, DtoCustomer>();
            cfg.CreateMap<Order, DtoOrder>();
            cfg.CreateMap<PromotionDetail, DtoPromotionDetail>();

            cfg.CreateMap<CreateSupplierRequest, Supplier>();
            cfg.CreateMap<CreateCustomerRequest, Customer>();
            cfg.CreateMap<CreatePromotionDetailRequest, PromotionDetail>();


        }
    }
}
