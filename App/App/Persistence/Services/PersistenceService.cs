using App.Persistence.Data;

namespace App.Persistence.Services
{
    public abstract class PersistenceService<PM, K> : IPersistenceService
    {
        protected AppDatabaseContext databaseContext = new AppDatabaseContext();

        public PM? Create(PM entity)
        {
            var created = databaseContext.Add(entity);
            databaseContext.SaveChanges();
            return (PM?)created.Entity;
        }
        public PM? Delete(PM entity)
        {
            var deleted = databaseContext.Add(entity);
            databaseContext.SaveChanges();
            return (PM?)deleted.Entity;
        }
        public PM? Read(K id)
        {
            var persisted = databaseContext.Find(typeof(PM),id);
            databaseContext.SaveChanges();
            return (PM?)persisted;
        }
        public PM? Update(PM entity)
        {
            var updated = databaseContext.Update(entity);
            databaseContext.SaveChanges();
            return (PM?)updated.Entity;
        }
    }
}