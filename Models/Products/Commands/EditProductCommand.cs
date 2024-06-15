namespace Eshop.RazorPage.Models.Products.Commands;

public class EditProductCommand
{
    public long ProductId { get; private set; }
    public string Title { get; private set; }
    public IFormFile? ImageFile { get; private set; }
    public string Description { get; private set; }
    public long CategoryId { get; private set; }
    public long SubCategoryId { get; private set; }
    public long SecondarySubCategoryId { get; private set; }
    public string Slug { get; private set; }
    public SeoData SeoData { get; private set; }
    public Dictionary<string, string> Specifications { get; private set; }

}
