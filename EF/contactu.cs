namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class contactu
    {
        public int id { get; set; }
        [Display(Name="نام و نام خانوادگی")]
        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string website { get; set; }

        [StringLength(20)]
        public string subject { get; set; }

        public string message { get; set; }
    }
    public static partial class contactus
    {
        public static void insertcontact(contactu cmt)
        {
            DB person = new DB();
            person.contactus.Add(cmt);
            person.SaveChanges();
        }
    }
}
