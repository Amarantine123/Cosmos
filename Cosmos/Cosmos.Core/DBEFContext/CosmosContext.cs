using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.Core.Extension.AutofacManager;
using Cosmos.Core.DBManger;
using Cosmos.Core.Const;
using Cosmos.Core.Enums;
using Microsoft.Extensions.DependencyModel;
using System.Linq;
using System.Runtime.Loader;
using System.Reflection;
using Cosmos.Entity;
using Cosmos.Core.Extension;

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
            string connectionStr = DBServerProvider.GetConnectionString(null);
            if (DBType.Name==DbCurrentType.MySql.ToString())
            {
                optionsBuilder.UseMySql(connectionStr);
            }
            else if (DBType.Name==DbCurrentType.PgSql.ToString())
            {
                optionsBuilder.UseNpgsql(connectionStr);
            }
            else
            {
                optionsBuilder.UseSqlServer(connectionStr);
            }

            // Default: disable query tracking
            optionsBuilder = optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Type type = null;
            try
            {
                var compilationLibary = DependencyContext.Default.CompileLibraries.Where(x => !x.Serviceable && x.Type != "package" && x.Type == "project");

                foreach (var _compilation in compilationLibary)
                {
                    AssemblyLoadContext.Default.LoadFromAssemblyName(new System.Reflection.AssemblyName(_compilation.Name)).GetTypes().Where(x => x.GetTypeInfo().BaseType != null && x.BaseType == (typeof(BaseEntity))).ToList().ForEach(
                        t => modelBuilder.Entity(t));
                }
                base.OnModelCreating(modelBuilder);
            }
            catch (Exception ex)
            {
                string mapPath = ($"Log/").MapPath();
                Utilities.FileHelper.WriteFile(mapPath,
                    $"syslog_{DateTime.Now.ToString("yyyyMMddHHmmss")}.txt",
                    type?.Name + "--------" + ex.Message + ex.StackTrace + ex.Source);
            }
        }
    }
}
