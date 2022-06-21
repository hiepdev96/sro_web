using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Generics
{
    public class GenericService<T, C> : IDisposable where T : class where C : DbContext
    {

        protected DbRepository<T, C> repository;

        public C DbContext { get; set; }

        //SSOReportEntities _rpcontext;
        //public SSOReportEntities DbReportContext
        //{
        //    get
        //    {
        //        if (_rpcontext == null)
        //        {
        //            _rpcontext = new SSOReportEntities();
        //        }
        //        return _rpcontext;
        //    }
        //}

        public GenericService(C context)
        {
            this.DbContext = context;
            this.repository = new DbRepository<T, C>(context);
        }

        public virtual B GetService<B>()
        {
            return (B)typeof(B).GetConstructor(new Type[] { typeof(C) }).Invoke(new object[] { this.DbContext });
        }

        public virtual DbRepository<B, C> GetDbRepository<B>() where B : class
        {
            return new DbRepository<B, C>(this.DbContext);
        }

        public virtual IQueryable<T> All
        {
            get { return repository.All; }
        }
        public virtual IQueryable<T> AllNoTracking
        {
            get { return repository.AllNoTracking; }
        }
        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return repository.AllIncluding(includeProperties);
        }

        public virtual T Find(object id)
        {
            return repository.Find(id);
        }
        public virtual T Find(string name)
        {
            return repository.Find(name);
        }
        public virtual T CheckExists(object id)
        {
            T t = repository.Find(id);
            if (t == null)
            {
                throw new Exception(
                    $"Không tồn tại bản ghi có id = {id} trong database");
            }
            return t;
        }

        public virtual T Find(params object[] objs)
        {
            return repository.Finds(objs);
        }
        public virtual T Insert(T entityToInsert)
        {
            repository.Insert(entityToInsert);
            return entityToInsert;
        }

        public virtual List<T> Insert(List<T> entityToInserts)
        {
            if (entityToInserts != null && entityToInserts.Any())
            {
                repository.Insert(entityToInserts);
            }
            return entityToInserts;
        }

        // insert new code

        public virtual IQueryable<E> GetAll<E>() where E : class
        {
            return repository.GetAll<E>();
        }

        public virtual E Insert<E>(E entityToInsert) where E : class
        {
            repository.Insert<E>(entityToInsert);
            return entityToInsert;
        }

        public virtual E Update<E>(E entityToUpdate) where E : class
        {
            repository.Update<E>(entityToUpdate);
            return entityToUpdate;
        }

        public virtual void Delete<E>(object id) where E : class
        {
            repository.Delete<E>(id);

        }

        public virtual E Find<E>(object id) where E : class
        {
            return repository.Find<E>(id);
        }
        //the end

        public virtual T Update(T entityToUpdate)
        {
            repository.Update(entityToUpdate);
            return entityToUpdate;
        }

        public virtual T InsertAndSave(T entityToInsert)
        {
            repository.InsertAndSave(entityToInsert);
            return entityToInsert;
        }

        public virtual E InsertAndSave<E>(E entityToInsert) where E : class
        {
            repository.InsertAndSave(entityToInsert);
            return entityToInsert;
        }

        public virtual T UpdateAndSave(T entityToUpdate)
        {
            repository.UpdateAndSave(entityToUpdate);
            return entityToUpdate;
        }
        public virtual void UpdateAndSave(ICollection<T> entityToUpdates)
        {
            foreach (var entityToUpdate in entityToUpdates)
            {
                repository.UpdateAndSave(entityToUpdate);
            }
        }

        public virtual void Delete(object id)
        {
            repository.Delete(id);
        }
        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual void DeleteAndSave(T entity)
        {
            repository.DeleteAndSave(entity);
        }

        public virtual void DeleteBy(Expression<Func<T, bool>> expression, params object[] parameters)
        {
            repository.DeleteBy(expression, parameters);
        }
        public virtual void DeleteAll(List<T> entities)
        {
            repository.DeleteAll(entities);
        }
        public virtual void Save()
        {
            repository.Save();
        }
        public string GetFilePath(string relativePath)
        {
            string assemblyFolder = Path.GetDirectoryName(
              new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            return Path.Combine(assemblyFolder,
                   relativePath);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public void Dispose()
        //{
        //    if (_rpcontext != null)
        //    {
        //        _rpcontext.Dispose();
        //    };
        //}
    }
}
