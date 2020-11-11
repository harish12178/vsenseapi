using Microsoft.EntityFrameworkCore;
using VSense.API.Models;
namespace VSense.API.Context
{
    public class DeviceContext:DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options): base(options)
        {

        }
        public DbSet <Device_log> Device_log { get; set; }
        public DbSet <m_device> m_device { get; set; }
        public DbSet <m_device_param> m_device_param { get; set; }
        public DbSet <m_equipment> m_equipment { get; set; }
        public DbSet <m_Loc> m_Loc { get; set; }
        // public DbSet <m_TrkDo> m_TrkDo { get; set; }
        public DbSet <t_device_assign> t_device_assign { get; set; }
        public DbSet <t_device_assign_param> t_device_assign_param { get; set; }
        // public DbSet <t_trkdo_assign> t_trkdo_assign { get; set; }
        // public DbSet <t_TrkDoLog> t_TrkDoLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            // modelBuilder.Entity<m_device_param>()
            //     .HasMany(c => c.paramAssigns)
            //     .WithOne(e => e.deviceParam);
            //modelBuilder.Entity<t_device_assign_param>().HasNoKey();
            modelBuilder.Entity<m_device>()
                .HasMany(c => c.deviceParams)
                .WithOne(e => e.device);
            // modelBuilder.Entity<m_device>()
            //     .HasMany(c => c.deviceAssigns)
            //     .WithOne(e => e.device);
        }
        
    }
}