using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GearStore.Models
{
    public class SignInViewModel
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

    public class SignUpViewModel
    {
        [DisplayName("Mã khách hàng")]
        public int CustomerID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Tài khoản")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Họ và tên")]
        public string FullName { get; set; }
        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Địa chỉ")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [DisplayName("Số điện thoại")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
    public class AcccountDetailsViewModel
    {
        [DisplayName("Mã khách hàng")]
        public int CustomerID { get; set; }
        [DisplayName("Tài khoản")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Họ và tên")]
        [Required]
        [DataType(DataType.Text)]
        public string FullName { get; set; }
        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
        [DisplayName("Giới tính")]
        public bool Gender { get; set; }
        [DisplayName("Địa chỉ")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [DisplayName("Số điện thoại")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}