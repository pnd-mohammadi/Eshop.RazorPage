using Eshop.RazorPage.Infrastructure.RazorUtils;
using Eshop.RazorPage.Models.Auth;
using Eshop.RazorPage.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Eshop.RazorPage.Pages.Auth
{
    [BindProperties]
    [ValidateAntiForgeryToken]
    public class RegisterModel : BaseRazorPage
    {
        private readonly IAuthService _authService;

        public RegisterModel(IAuthService authService)
        {
            _authService = authService;
        }

        [Display(Name ="شماره تلفن  ")]
        [Required(ErrorMessage ="{0} را وارد کنید ")]
        public string PhoneNumber { get; set; }
         
        [Display(Name = "کلمه عبور  ")]
        [Required(ErrorMessage = "{0} را وارد کنید ")]
        [MinLength(5,ErrorMessage = "کلمه عبور باید بزرگتر ار 5 کاراکتر باشد")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Display(Name = "کلمه عبور  ")]
        [Required(ErrorMessage = "{0} را وارد کنید ")]
        [MinLength(5, ErrorMessage = "کلمه عبور باید بزرگتر ار 5 کاراکتر باشد")]
        [DataType(DataType.Password)]
        public string ConfirmPassWord { get; set; }  

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            var result =await _authService.Register(new RegisterCommand()
            {
                PhoneNumber = PhoneNumber,
                Password = PassWord,
                ConfirmPassword = ConfirmPassWord
            });
            //if (result.IsSuccess == false)
            //{
            //    ModelState.AddModelError(nameof(PhoneNumber), result.MetaData.Message);
            //    return Page();
            //}
            //return RedirectToPage("Login");
            return RedirectAndShowAlert(result, RedirectToPage("Login"));
        }
    }
}
