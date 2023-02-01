using Entities.Entities;

namespace MINERALIZER_API.iServices
{
    public interface IOrderService
    {
        int InsertOrder(OrderItem userItem);
    }
}
