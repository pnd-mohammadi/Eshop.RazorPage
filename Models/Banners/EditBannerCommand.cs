using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Eshop.RazorPage.Models.Banners
{
    public class EditBannerCommand
    {
        public long Id { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "  {را وارد کنید{0")]
        [DataType(DataType.Url)]
        public string Link { get; set; }


        [Display(Name = "عکس")]
        [Required(ErrorMessage = "  {را وارد کنید{0")]
        //[FileImage(ErrorMessage = "عکس تانعتبر است")]
        public IFormFile ImageFile { get; set; }
        public BannerPosition Position { get; set; }
    }
}
