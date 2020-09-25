
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
    
public partial class HeaderDetail
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public HeaderDetail()
    {

        this.Documents = new HashSet<Document>();

        this.Images = new HashSet<Image>();

    }


    public int Id { get; set; }

    public string Name { get; set; }

    public string Alias { get; set; }

    public Nullable<int> HeaderCategoryId { get; set; }

    public Nullable<int> ParentId { get; set; }



    public virtual HeaderCategory HeaderCategory { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Document> Documents { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Image> Images { get; set; }

}

}
