using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
    public class LoginVm
    {
        [Required(ErrorMessage = "Username is Required")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }

        [Display(Name = "RememberMe")]   
        public bool RememberMe { get; set; }
    }
}
