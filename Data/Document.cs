//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        public int Id { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public bool IsActive { get; set; }
        public string FileName { get; set; }
    
        public virtual HeaderDetail HeaderDetail { get; set; }
    }
}
