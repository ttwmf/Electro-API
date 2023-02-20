﻿using AutoMapper;
using ElectroECommerce.Application.Models.Dtos;
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
        }
    }
}
