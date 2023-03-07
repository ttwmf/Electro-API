using ElectroECommerce.Application.Models.Dtos;
using ElectroECommerce.Application.Models.Request;
using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IOrderService
    {
        Task<DtoOrder> GetOrderByIdAsync(int id);
        Task<IEnumerable<DtoOrder>> GetAllOrderAsync();
        Task<Order> CreateOrderAsync(CreateOrderRequest order);
        Task<Order> UpdateOrderAsync(UpdateOrderRequest order, int id);
        Task DeleteOrderAsync(int id);
    }
}
