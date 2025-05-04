namespace JqueryAjaxKullanimi.Models
{
    using System.Data.Entity;

    public partial class AjaxTestModel : DbContext
    {
        public AjaxTestModel()
            : base("name=AJTModel")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
