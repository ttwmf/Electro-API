using ElectroECommerce.Domain;

namespace ElectroECommerce.Application.Contracts
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(int id);
    }
}
