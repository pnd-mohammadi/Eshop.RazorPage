using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Orders;
using Eshop.RazorPage.Models.Orders.Commands;

namespace Eshop.RazorPage.Services.Orders
{
    public class OrderService : IOrderService
    {
        public Task<ApiResult> AddItemOrder(AddItemOrderCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> CheckoutOrder(CheckoutOrderCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> DecreaseItemCount(DecreaseItemCountCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> DeleteItemOrder(DeleletItemOrderCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto?> GetCurrentOrder()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> GetOrderById(long orderId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderFilterResult> GetOrders(OrderFilterParams filterParams)
        {
            throw new NotImplementedException();
        }

        public Task<OrderFilterResult> GetUserOrders(int pageId, int take, OrderStatus? orderStatus)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> IncreaseItemCount(IncreaseItemCountCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> SendOrder(long orderId)
        {
            throw new NotImplementedException();
        }
    }
}
