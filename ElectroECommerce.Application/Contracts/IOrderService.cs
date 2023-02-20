
using ElectroECommerce.Application.Models.Dtos;

namespace ElectroECommerce.Application.Contracts
{
    public interface IOrderService
    {
        Task<DtoOrder> GetOrderByIdAsync(int id);
    }
}
