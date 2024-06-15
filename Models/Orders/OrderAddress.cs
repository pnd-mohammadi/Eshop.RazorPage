namespace Eshop.RazorPage.Models.Orders;

public class OrderAddress:BaseDto
{
    public long OrderId { get; internal set; }
    public string Shire { get;  set; }
    public string City { get;  set; }
    public string PostalCode { get;  set; }
    public string PostalAddress { get;  set; }
    public string PhoneNumber { get;  set; }
    public string Name { get;  set; }
    public string Family { get;  set; }
    public string NationalCode { get;  set; }

}
