namespace Eshop.RazorPage.Models.Orders;

public class OrderShippingMethod :BaseDto
{
    public string ShippingType { get;  set; }
    public int ShippingCost { get;  set; }
}