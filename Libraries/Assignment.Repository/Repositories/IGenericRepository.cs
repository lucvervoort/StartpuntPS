using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Assignment.Repository.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        #region Properties
        DbSet<TEntity> Set { get; set; }
        #endregion

        #region Methods
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "");
        TEntity? GetByID(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        #endregion
    }
}