using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GearStore.Areas.Administrator.Models
{
    public class EmployeeSignInViewModel
    {
        [DisplayName("Tài khoản")]
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}