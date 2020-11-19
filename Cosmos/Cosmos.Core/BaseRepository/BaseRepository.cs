using Cosmos.Core.Dapper;
using Cosmos.Core.DBEFContext;
using Cosmos.Core.Enums;
using Cosmos.Core.Utilities;
using Cosmos.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core.BaseProvider.BaseRepository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Public Properties
        public CosmosContext DefaultDbContext { get; set; }

        public ISqlDapper DapperContext => throw new NotImplementedException();

        #endregion

        #region Private Properties
        private CosmosContext EFContext
        {
            get { return DefaultDbContext; }
        }
        #endregion

        #region Constructor
        public BaseRepository()
        {

        }

        public BaseRepository(CosmosContext dbContext)
        {
            this.DefaultDbContext = dbContext ?? throw new Exception("DbContext is not instantiated");
        }

        #endregion




       

        public void Add(TEntity entities, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities, bool SaveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void AddRange<T>(IEnumerable<T> entities, bool saveChanges = false) where T : class
        {
            throw new NotImplementedException();
        }

        public void BulkInsert(IEnumerable<TEntity> entities, bool setOutputIdentity = false)
        {
            throw new NotImplementedException();
        }

        public HttpResponse DbContextBeginTransaction(Func<HttpResponse> action)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity model, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public int Delete(object[] keys, bool delList = false)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(string sql, params SqlParameter[] sqlParameters)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Exists<TExists>(Expression<Func<TExists, bool>> predicate) where TExists : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync<TExists>(Expression<Func<TExists, bool>> predicate) where TExists : class
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Find(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public List<T> Find<T>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T>> selector)
        {
            throw new NotImplementedException();
        }

        public List<TFind> Find<TFind>(Expression<Func<TFind, bool>> predicate) where TFind : class
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Find<Source>(IEnumerable<Source> sources, Func<Source, Expression<Func<TEntity, bool>>> predicate) where Source : class
        {
            throw new NotImplementedException();
        }

        public List<TResult> Find<Source, TResult>(IEnumerable<Source> sources, Func<Source, Expression<Func<TEntity, bool>>> predicate, Expression<Func<TEntity, TResult>> selector) where Source : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindAsIQueryable(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Dictionary<object, QueryOrderBy>>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindAsIQueryable<Source>(IEnumerable<Source> sources, Func<Source, Expression<Func<TEntity, bool>>> predicate) where Source : class
        {
            throw new NotImplementedException();
        }

        public Task<List<TFind>> FindAsync<TFind>(Expression<Func<TFind, bool>> predicate) where TFind : class
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindAsync<T>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T>> selector)
        {
            throw new NotImplementedException();
        }

        public Task<TFind> FindAsyncFirst<TFind>(Expression<Func<TFind, bool>> predicate) where TFind : class
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsyncFirst(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity FindFirst(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Dictionary<object, QueryOrderBy>>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindFirstAsync<T>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T>> selector)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> FromSql(string sql, params SqlParameter[] sqlParameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FromSqlInterpolated([NotNull] FormattableString sql)
        {
            throw new NotImplementedException();
        }

        public Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<TEntity, TProperty> Include<TProperty>(Expression<Func<TEntity, TProperty>> incluedProperty)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TFind> IQueryablePage<TFind>(int pageIndex, int pagesize, out int rowcount, Expression<Func<TFind, bool>> predicate, Expression<Func<TEntity, Dictionary<object, QueryOrderBy>>> orderBy, bool returnRowCount = true) where TFind : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> IQueryablePage(IQueryable<TEntity> queryable, int pageIndex, int pagesize, out int rowcount, Dictionary<string, QueryOrderBy> orderBy, bool returnRowCount = true)
        {
            throw new NotImplementedException();
        }

        public List<TResult> QueryByPage<TResult>(int pageIndex, int pagesize, out int rowcount, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Dictionary<object, QueryOrderBy>>> orderBySelector, Expression<Func<TEntity, TResult>> selectorResult, bool returnRowCount = true)
        {
            throw new NotImplementedException();
        }

        public List<TResult> QueryByPage<TResult>(int pageIndex, int pagesize, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Dictionary<object, QueryOrderBy>>> orderBy, Expression<Func<TEntity, TResult>> selectorResult = null)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> QueryByPage(int pageIndex, int pagesize, out int rowcount, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Dictionary<object, QueryOrderBy>>> orderBy, bool returnRowCount = true)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity, Expression<Func<TEntity, object>> properties, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public int Update<TSource>(TSource entity, Expression<Func<TSource, object>> properties, bool saveChanges = false) where TSource : class
        {
            throw new NotImplementedException();
        }

        public int Update<TSource>(TSource entity, bool saveChanges = false) where TSource : class
        {
            throw new NotImplementedException();
        }

        public int Update<TSource>(TSource entity, string[] properties, bool saveChanges = false) where TSource : class
        {
            throw new NotImplementedException();
        }

        public int UpdateRange<TSource>(IEnumerable<TSource> entities, bool saveChanges = false) where TSource : class
        {
            throw new NotImplementedException();
        }

        public int UpdateRange<TSource>(IEnumerable<TSource> models, Expression<Func<TSource, object>> properties, bool saveChanges = false) where TSource : class
        {
            throw new NotImplementedException();
        }

        public int UpdateRange<TSource>(IEnumerable<TSource> entities, string[] properties, bool saveChanges = false) where TSource : class
        {
            throw new NotImplementedException();
        }

        public HttpResponse UpdateRange<Detail>(TEntity entity, bool updateDetail = false, bool delNotExist = false, Expression<Func<TEntity, object>> updateMainFields = null, Expression<Func<Detail, object>> updateDetailFields = null, bool saveChange = false) where Detail : class
        {
            throw new NotImplementedException();
        }
    }
}
