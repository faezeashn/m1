using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject1.Models
{
    public class Products
    {

        [Key]
        [Required]
        [Display(Name = "شماره محصول")]
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        [Display(Name = "طبقه بندی محصولات")]

        public int? CategoryId { get; set; }
      
        

        public virtual Country Country { get; set; }
        [Display(Name = "کشورتولید کننده")]

        public int? CountryId { get; set; }

        [Display(Name = "نام محصول")]
        public string BrandName { get; set; }




        [Display(Name = "مدل محصول")]
        public string ModelNo { get; set; }
      
       
        public virtual Company Company { get; set; }
        [Display(Name = "شرکت تولید کننده ")]
        public int? CompanyId { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }
       
    }
}