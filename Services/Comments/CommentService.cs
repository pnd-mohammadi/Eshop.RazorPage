using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Comments;

namespace Eshop.RazorPage.Services.Comments
{
    public class CommentService : ICommentService
    {
        public Task<ApiResult> AddComment(AddCommentCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> ChangeStatus(long commentId, CommentStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> DeleteComment(long commentId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult> EditComment(EditCommentCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> GetById(long commantId)
        {
            throw new NotImplementedException();
        }

        public Task<CommentFilterResult> GetCommentByFilter(CommentFilterParams filterParams)
        {
            throw new NotImplementedException();
        }

        public Task<CommentFilterResult> GetProductComments(int pageId, int take, long productId)
        {
            throw new NotImplementedException();
        }
    }
}
