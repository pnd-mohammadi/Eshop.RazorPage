namespace Eshop.RazorPage.Models.Categories;

public class CategoryDto
{
    public string Title { get;  set; }
    public string Slug { get;  set; }
    public SeoData SeoData { get;  set; }
    public List<ChildCategoryDto> Childs { get;  set; }
}
public class ChildCategoryDto 
{
    public string Title { get; set; }
    public string Slug { get; set; }
    public SeoData SeoData { get; set; }
    public long ParentId { get; set; }
    public List<SecondaryChildCategoryDto> Childs { get; set; }
}

public class SecondaryChildCategoryDto 
{
    public string Title { get; set; }
    public string Slug { get; set; }
    public SeoData SeoData { get; set; }
    public long ParentId { get; set; }
}