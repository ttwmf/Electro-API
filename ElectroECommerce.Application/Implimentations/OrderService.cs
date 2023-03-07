using AutoMapper;
using ElectroECommerce.Application.Contracts;
using ElectroECommerce.Application.IRepositories;
using ElectroECommerce.Application.Models.Dtos;
using ElectroECommerce.Application.Models.Request;
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
        public async Task<IEnumerable<DtoOrder>> GetAllOrderAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            var dtoOrders = _mapper.Map<IEnumerable<DtoOrder>>(orders);
            return dtoOrders;
        }

        public async Task<Order> CreateOrderAsync(CreateOrderRequest order)
        {
            var newOrder = _mapper.Map<CreateOrderRequest, Order>(order);

            return await _orderRepository.CreateAsync(newOrder);
        }

        public async Task<Order> UpdateOrderAsync(UpdateOrderRequest order, int id)
        {
            var updateOrder = await _orderRepository.GetAsync(id);
            if (updateOrder != null)
            {
                updateOrder.ShippingAddress = order.ShippingAddress;
                updateOrder.ShippingCost = order.ShippingCost;
                updateOrder.PaymentMethod = order.PaymentMethod;
                updateOrder.TotalItems = order.TotalItems;
                updateOrder.TotalPrice = order.TotalPrice;
                updateOrder.TotalDiscount = order.TotalDiscount;
                updateOrder.VoucherCode = order.VoucherCode;
            }
            return await _orderRepository.UpdateAsync(updateOrder);
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _orderRepository.GetAsync(id);
            if (order != null)
            {
                await _orderRepository.DeleteAsync(order);
            }
        }
    }
}
