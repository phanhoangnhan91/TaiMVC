﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W_GJS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class O_CATEGORY_PAGE
    {
        public O_CATEGORY_PAGE()
        {
            this.M_PAGE = new HashSet<M_PAGE>();
        }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [Display(Name = "Danh mục trang")]
        public long CATEGORY_PAGE_CD { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Mã danh mục trang")]
        public string CATEGORY_PAGE_CODE { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Danh mục trang")]
        public string CATEGORY_PAGE_NAME { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Thẻ alt")]
        public string TAG_ALT { get; set; }
        public Nullable<long> STATUS { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
    
        public virtual ICollection<M_PAGE> M_PAGE { get; set; }
    }
}
