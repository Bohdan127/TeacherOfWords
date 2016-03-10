using DbManagerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DbManagerLibrary.DefaultManagers.Repositories
{
    public class Repository<TContext> : IRepository
      where TContext : DbContext, new()
    {//implementation of our repository for right using our context
        public Repository()
        {
            Context = new TContext();//template for our context
        }

        public TContext Context { get; private set; }

        /// <summary>
        /// Delete item from table T
        /// </summary>
        /// <typeparam name="T">here should be table</typeparam>
        /// <param name="item">item for delete</param>
        /// <param name="saveNow">true: save changes immediately</param>
        /// <returns></returns>
        public T Delete<T>(T item, bool saveNow) where T : class
        {
            Context.Entry(item).State = EntityState.Deleted;
            if (saveNow)
                Save();
            return item;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        /// <summary>
        /// Insert an item into table T
        /// </summary>
        /// <typeparam name="T">here should be table</typeparam>
        /// <param name="item">item for insert</param>
        /// <param name="saveNow">true: save changes immediately</param>
        /// <returns></returns>
        public T Insert<T>(T item, bool saveNow) where T : class
        {
            Context.Entry(item).State = EntityState.Added;
            if (saveNow)
                Save();

            return item;
        }

        /// <summary>
        /// Save changes immediately
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            //todo here can be a lot of exceptions maybe we should place here try/catch but with right behavior
            return Context.SaveChanges();
        }

        /// <summary>
        /// Get all collection from table T
        /// </summary>
        /// <typeparam name="T">here should be table</typeparam>
        /// <returns></returns>
        public IEnumerable<T> Select<T>() where T : class
        {
            return Context.Set<T>();
        }

        /// <summary>
        /// update item in table T
        /// </summary>
        /// <typeparam name="T">here should be table</typeparam>
        /// <param name="item">item for update</param>
        /// <param name="saveNow">true: save changes immediately</param>
        /// <returns></returns>
        public T Update<T>(T item, bool saveNow) where T : class
        {
            Context.Entry(item).State = EntityState.Modified;
            if (saveNow)
                Save();

            return item;
        }
    }

}
