//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLServerECommerce.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Category1 = new HashSet<Category>();
            this.ProductCategories = new HashSet<ProductCategory>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> parent_id { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<Category> Category1 { get; set; }
        public virtual Category Category2 { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
