using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TeacherOfWords.Data
{
    //
    //Source http://stackoverflow.com/questions/29050400/generic-repository-for-sqlite-net-in-xamarin-project
    //

    public interface IRepository<T> where T : class, new()
    {
        Task<List<T>> Get();
        Task<T> Get(long id);
        Task<List<T>> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        AsyncTableQuery<T> AsQueryable();
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
