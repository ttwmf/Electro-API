using AutoMapper;
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Dtos;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Implimentations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<DtoOrder> GetOrderByIdAsync(int id)
        {
            var order = await _orderRepository.GetAsync(id);

            var dtoOrder = _mapper.Map<Order, DtoOrder>(order);

            return dtoOrder;
        }
    }
}
