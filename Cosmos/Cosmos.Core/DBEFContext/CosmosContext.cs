using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.Core.Extension.AutofacManager;

namespace Cosmos.Core.DBEFContext
{
    public class CosmosContext : DbContext, IDependency
    {
        private string ConnectionString { get; set; } = null;
        public CosmosContext():base()
        {
                
        }
        public CosmosContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public CosmosContext(DbContextOptions<CosmosContext>options):base(options){}


        public override void Dispose()
        {
            base.Dispose();
        }


        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {

                throw (ex.InnerException as Exception ?? ex);
            }
        }


        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }


        public bool QueryTrancking
        {
            set
            {
                this.ChangeTracker.QueryTrackingBehavior = value ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;
            }
        }

        /// <summary>
        /// Called for each instance of the context that is created.
        /// </summary>
        /// <param name="optionsBuilder">Configure the database connection</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionStr=DBService

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
