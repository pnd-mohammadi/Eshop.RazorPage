using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Categories;

namespace Eshop.RazorPage.Services.Categories
{
    public interface ICategoryService
    {
        Task<ApiResult> AddChildCategory(AddChildCategoryCommand commnad);
        Task<ApiResult> CreateCateory(CreateCategoryCommand command);
        Task<ApiResult> EditCategory(EditCategoryCommand commnad);
        Task<ApiResult> DeleteCategory(long categoryId);
        Task<CategoryDto> GetCategoryById(long catagoryId);
        Task<List<CategoryDto>> GetCategories();
        Task<List<ChildCategoryDto>> GetChild(long parentCategoryId);
    }
}
