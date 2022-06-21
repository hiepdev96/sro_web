using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Generics
{
    public class DbRepository<T, C> where T : class where C : DbContext
    {
        internal C Context;
        internal DbSet<T> DbSet;

        public DbRepository(C context)
        {
            Context = context;
            DbSet = Context.Set<T>();
            DbSet.AsNoTracking();
        }

        public IQueryable<T> All
        {
            get { return DbSet; }
        }
        public IQueryable<T> AllNoTracking
        {
            get { return DbSet.AsNoTracking(); }
        }
        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = DbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }
        public T Find(object id)
        {
            return DbSet.Find(id);
        }

        public T Finds(params object[] objs)
        {
            return DbSet.Find(objs);
        }
        public void Insert(T entityToInsert)
        {
            DbSet.Add(entityToInsert);
        }

        public void Insert(List<T> entityToInserts)
        {
            DbSet.AddRange(entityToInserts);
        }

        public IQueryable<E> GetAll<E>() where E : class
        {
            return Context.Set<E>();
        }

        public E Find<E>(object id) where E : class
        {
            return Context.Set<E>().Find(id);
        }

        public void Insert<E>(E entityToInsert) where E : class
        {
            Context.Set<E>().Add(entityToInsert);
        }

        public void Update<E>(E entityToUpdate) where E : class
        {
            Context.Set<E>().Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void InsertAndSave(T entityToInsert)
        {
            Insert(entityToInsert);
            Save();
        }

        public void InsertAndSave<E>(E entityToInsert) where E : class
        {
            Insert(entityToInsert);
            Save();
        }

        public void Delete<E>(object id) where E : class
        {
            E entityToDelete = Context.Set<E>().Find(id);
            this.Delete(entityToDelete);
        }

        public void Update(T entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void UpdateAndSave(T entityToUpdate)
        {
            Update(entityToUpdate);
            Save();
        }


        public void Delete(T entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        public void DeleteAndSave(T entityToDelete)
        {
            Delete(entityToDelete);
            Save();
        }
        public void Delete(object id)
        {
            T entityToDelete = DbSet.Find(id);
            this.Delete(entityToDelete);
        }
        public void DeleteBy(Expression<Func<T, bool>> expression, params object[] parameters)
        {
            var query = this.All.Where(expression);
            string sqlSelect = query.ToString();
            int ind = sqlSelect.ToLower().IndexOf("from ");
            string sqlDelete = "delete " + sqlSelect.Substring(ind);
            ((IObjectContextAdapter)Context).ObjectContext.ExecuteStoreCommand(sqlDelete, parameters);
        }
        public void DeleteAll(List<T> entities)
        {
            foreach (T entity in entities)
            {
                this.Delete(entity);
            }
        }



        public void Save()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                string error = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        error += string.Format("{0}:{1}; ", ve.PropertyName, ve.ErrorMessage);
                    }

                }
                throw new Exception(error);
            }
        }
        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}