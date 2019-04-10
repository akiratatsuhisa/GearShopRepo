using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GearStore.Areas.Administrator.Models
{
    public class ProductViewModel
    {
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Thể loại")]
        [Required]
        public int CategoryID { get; set; }
        [DisplayName("Hãng SX")]
        [Required]
        public int ManufacturerID { get; set; }
        [DisplayName("Giá")]
        [Required]
        [Range(0,double.PositiveInfinity)]
        public decimal Price { get; set; }
        [DisplayName("Ảnh")]
        public string PhotoFilePatch { get; set; }
        [DisplayName("Số lượng trong kho")]
        [Required]
        [Range(1, int.MaxValue)]
        public int UnitsInStock { get; set; }
        [DisplayName("Ngày cập nhật")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss.fff}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        [DisplayName("Reorder Level")]
        public int ReorderLevel { get; set; }
        [Required]
        [Range(0, 5)]
        [DisplayName("Rating")]
        public byte Rating { get; set; }
        [DisplayName("Dừng bán")]
        public bool Discontinued { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Chi tiết")]
        public string Details { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        public HttpPostedFileBase UploadImage { get; set; }
    }
}