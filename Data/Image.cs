
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
    
public partial class Image
{

    public int Id { get; set; }

    public string ImageDescription { get; set; }

    public string FilePath { get; set; }

    public string MinimalFilePath { get; set; }

    public Nullable<System.DateTime> DatePosted { get; set; }

    public bool IsActive { get; set; }

    public Nullable<int> HeaderDetailId { get; set; }



    public virtual HeaderDetail HeaderDetail { get; set; }

}

}
