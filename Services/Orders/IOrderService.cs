using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Orders;
using Eshop.RazorPage.Models.Orders.Commands;

namespace Eshop.RazorPage.Services.Orders;

public interface IOrderService
{
    Task<ApiResult> AddItemOrder(AddItemOrderCommand command);
    Task<ApiResult> CheckoutOrder(CheckoutOrderCommand command);
    Task<ApiResult> DecreaseItemCount(DecreaseItemCountCommand command);
    Task<ApiResult> IncreaseItemCount(IncreaseItemCountCommand command);
    Task<ApiResult> DeleteItemOrder(DeleletItemOrderCommand command);
    Task<ApiResult> SendOrder(long orderId);

    Task<OrderDto>GetOrderById(long orderId);
    Task<OrderDto?> GetCurrentOrder();
    Task<OrderFilterResult> GetOrders(OrderFilterParams filterParams);
    Task<OrderFilterResult> GetUserOrders(int pageId, int take, OrderStatus? orderStatus);




}
