using Eshop.RazorPage.Models;
using Eshop.RazorPage.Models.Comments;

namespace Eshop.RazorPage.Services.Comments;

public interface ICommentService
{
    Task<ApiResult> EditComment(EditCommentCommand command);
    Task<ApiResult> AddComment(AddCommentCommand command);
    Task<ApiResult> DeleteComment(long commentId);
    Task<ApiResult> ChangeStatus(long commentId, CommentStatus status);

    Task<CommentDto> GetById(long commantId);
    Task<CommentFilterResult> GetCommentByFilter(CommentFilterParams filterParams);
    Task<CommentFilterResult> GetProductComments(int pageId, int take, long productId);
}
