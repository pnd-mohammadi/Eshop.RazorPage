using System.ComponentModel.DataAnnotations;

namespace Eshop.RazorPage.Models.Banners
{
    public class CreateBannerCommand
    {
        [Display(Name ="لینک")]
        [Required(ErrorMessage ="  {را وارد کنید{0")]
        [DataType(DataType.Url)]
        public string Link { get; set; }


        [Display(Name ="عکس")]
        [Required(ErrorMessage = "  {را وارد کنید{0")]
        //[FileImage(ErrorMessage="عکس تانعتبر است")]
        public IFormFile ImageFile { get; set; }

        public BannerPosition Position { get; set; }
    }
}
