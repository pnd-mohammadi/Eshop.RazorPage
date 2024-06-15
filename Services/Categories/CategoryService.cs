using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Categories;

namespace Eshop.RazorPage.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        public Task<ApiResult> AddChildCategory(AddChildCategoryCommand commnad)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> CreateCateory(CreateCategoryCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> DeleteCategory(long categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditCategory(EditCategoryCommand commnad)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryById(long catagoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildCategoryDto>> GetChild(long parentCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
