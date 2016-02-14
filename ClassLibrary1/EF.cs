namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EF : DbContext
    {
        public EF()
            : base("name=EF")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<contactus> contactus { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<SliderImages> SliderImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
