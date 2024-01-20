using App.Persistence.Data;

namespace App.Persistence.Services
{
    public abstract class PersistenceService <PM, ID> where PM : class
    {
        protected AppDatabaseContext databaseContext = new();

        public virtual PM? Create(PM entity)
        {   
            var created = databaseContext.Add(entity);
            databaseContext.SaveChanges();
            return created.Entity;
        }

        public virtual ISet<PM> GetAll() =>        
             databaseContext.Set<PM>().ToHashSet();

        public virtual void Delete(ID id)
        {
            var entity = GetById(id);
            if (entity != null) { 
                databaseContext.Remove(entity);
                databaseContext.SaveChanges();
            }
        }        

        public virtual PM? GetById(ID id) =>
            databaseContext.Find<PM>(id);
        
        public virtual void Update(PM entity) =>
            databaseContext.SaveChanges();
    }
}