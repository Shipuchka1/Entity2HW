namespace Entity2HW
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<newEquipment> newEquipment { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturer { get; set; }
        public virtual DbSet<TablesModel> TablesModel { get; set; }
        public virtual DbSet<TablesSNPrefix> TablesSNPrefix { get; set; }
        public virtual DbSet<TablesStopReason> TablesStopReason { get; set; }
        public virtual DbSet<TrackMeter> TrackMeter { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
