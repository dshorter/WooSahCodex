namespace WooSahCodex.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CFCodexModel : DbContext
    {
        public CFCodexModel()
            : base("name=CFCodexModel")
        {
        }

        public virtual DbSet<WooSah> WooSahs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
