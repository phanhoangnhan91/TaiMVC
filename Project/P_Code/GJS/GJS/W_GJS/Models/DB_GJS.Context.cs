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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GJSEntities : DbContext
    {
        public GJSEntities()
            : base("name=GJSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<D_ORDER_DETAIL> D_ORDER_DETAIL { get; set; }
        public virtual DbSet<D_PRODUCT_DETAIL> D_PRODUCT_DETAIL { get; set; }
        public virtual DbSet<M_EMPLOYEE> M_EMPLOYEE { get; set; }
        public virtual DbSet<M_PAGE> M_PAGE { get; set; }
        public virtual DbSet<O_ADVERTISEMENT> O_ADVERTISEMENT { get; set; }
        public virtual DbSet<O_BRANCH> O_BRANCH { get; set; }
        public virtual DbSet<O_CATEGORY_GRANULES> O_CATEGORY_GRANULES { get; set; }
        public virtual DbSet<O_CATEGORY_NEWS> O_CATEGORY_NEWS { get; set; }
        public virtual DbSet<O_CATEGORY_PAGE> O_CATEGORY_PAGE { get; set; }
        public virtual DbSet<O_CATEGORY_PRODUCT> O_CATEGORY_PRODUCT { get; set; }
        public virtual DbSet<O_CITIES> O_CITIES { get; set; }
        public virtual DbSet<O_CUSTOMER> O_CUSTOMER { get; set; }
        public virtual DbSet<O_INFORMATION> O_INFORMATION { get; set; }
        public virtual DbSet<O_NEWS> O_NEWS { get; set; }
        public virtual DbSet<O_NEWS_HIGHLIGHTS> O_NEWS_HIGHLIGHTS { get; set; }
        public virtual DbSet<O_NEWS_NEW> O_NEWS_NEW { get; set; }
        public virtual DbSet<O_ORDER> O_ORDER { get; set; }
        public virtual DbSet<O_PRODUCT> O_PRODUCT { get; set; }
        public virtual DbSet<O_PRODUCT_HIGHLIGHTS> O_PRODUCT_HIGHLIGHTS { get; set; }
        public virtual DbSet<O_PRODUCT_NEW> O_PRODUCT_NEW { get; set; }
        public virtual DbSet<O_PRODUCT_SELLING> O_PRODUCT_SELLING { get; set; }
        public virtual DbSet<O_SEO> O_SEO { get; set; }
        public virtual DbSet<O_USER_CUSTOMER> O_USER_CUSTOMER { get; set; }
        public virtual DbSet<O_USER_EMPLOYEE> O_USER_EMPLOYEE { get; set; }
        public virtual DbSet<O_USER_PST> O_USER_PST { get; set; }
        public virtual DbSet<S_PST> S_PST { get; set; }
        public virtual DbSet<S_STATISTICS_VISIT> S_STATISTICS_VISIT { get; set; }
        public virtual DbSet<S_USER> S_USER { get; set; }
        public virtual DbSet<W_PRODUCT> W_PRODUCT { get; set; }
    
        public virtual ObjectResult<SP_STATISTICS_VISIT_Result> SP_STATISTICS_VISIT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_STATISTICS_VISIT_Result>("SP_STATISTICS_VISIT");
        }
    }
}
