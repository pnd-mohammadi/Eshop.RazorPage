using Eshop.RazorPage.Infrastructure.RazorUtils;
using Eshop.RazorPage.Models.Auth;
using Eshop.RazorPage.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Eshop.RazorPage.Pages.Auth
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        private readonly IAuthService _authService;

        public LoginModel(IAuthService authService)
        {
            _authService = authService;
        }

        [Display(Name ="شماره تلفن")]
        [Required(ErrorMessage ="{0}را وارد کنید")]
        public string PhoneNumber { get; set; }
        [Display(Name ="کلمه عبور")]
        [Required(ErrorMessage ="{0}  را وارد کنید")]
        [MinLength(5,ErrorMessage ="تعداد کاراکترها باید بیشتر از 5 کاراکتر باشد")]
        [DataType(DataType.Password)]   
        public string PassWord { get; set; }

        public string RedirectTo { get; set; }
        public IActionResult OnGet(string redirectTo)
        {
            if (User.Identity.IsAuthenticated)
                return Redirect("/");

            RedirectTo = redirectTo;
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            var result = await _authService.Login(new LoginCommand()
            {
                PhoneNumber = PhoneNumber,
                Password = PassWord
            });
            if (result.IsSuccess == false)
            {
                ModelState.AddModelError(nameof(PhoneNumber), result.MetaData.Message);
                return Page();
            }
            var token = result.Data.Token;
            var refreshToken = result.Data.RefreshToken;
            HttpContext.Response.Cookies.Append("token", token);
            HttpContext.Response.Cookies.Append("refreshToken", refreshToken);
            //HttpContext.Response.Cookies.Append("token", token, new CookieOptions()
            //{
            //    HttpOnly = true,
            //    Expires = DateTimeOffset.Now.AddDays(7)
            //});
            //HttpContext.Response.Cookies.Append("refreshToken", refreshToken, new CookieOptions()
            //{
            //    HttpOnly = true,
            //    Expires = DateTimeOffset.Now.AddDays(10)
            //});

            return Redirect("/");
        }
    }
}
