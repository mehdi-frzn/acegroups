namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int ID { get; set; }
        
        public int NewsID { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(200)]
        public string Text { get; set; }

        public bool Status { get; set; }

        public virtual News News { get; set; }
    }
}
