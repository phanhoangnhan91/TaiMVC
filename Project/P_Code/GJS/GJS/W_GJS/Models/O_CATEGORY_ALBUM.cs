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
    
    public partial class O_CATEGORY_ALBUM
    {
        public O_CATEGORY_ALBUM()
        {
            this.O_ALBUM = new HashSet<O_ALBUM>();
        }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
       [Display(Name = "Danh mục Album")]
        public long CATEGORY_ALBUM_CD { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Tên Album")]
        public string CATEGORY_ALBUM_NAME { get; set; }
        public Nullable<long> STATUS { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
    
        public virtual ICollection<O_ALBUM> O_ALBUM { get; set; }
    }
}
