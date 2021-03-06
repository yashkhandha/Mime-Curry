//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cuisine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuisine()
        {
            this.Dishes = new HashSet<Dish>();
        }

        public int CuisineID { get; set; }
        [Display(Name = "Cuisine Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string CuisineName { get; set; }
        [Display(Name = "Cuisine Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string CuisineDescription { get; set; }
        [Display(Name = "Cuisine Make Year")]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> CuisineYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
