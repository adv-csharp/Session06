using Session06.DataModel;

namespace Session06
{

    public class Repository

    {
        AppDbContext db;


        public Repository()
        {
            db = new AppDbContext();
        }

        public void Add<T>(T model) where T : class
        {
            db.Set<T>().Add(model);
            db.SaveChanges();
        }

        public void Edit<T>(T model) where T : class
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            var model = Find<T>(id);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public T Find<T>(int id) where T : class
        {
            return db.Set<T>().Find(id);
        }

        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return db.Set<T>().AsQueryable();
        }
    }
    public class RepositoryOld<T>
        where T : class
    {
        AppDbContext db;


        public RepositoryOld()
        {
            db = new AppDbContext();
        }

        public void Add(T model)
        {
            db.Set<T>().Add(model);
            db.SaveChanges();
        }

        public void Edit(T model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IQueryable<T> AsQueryable()
        {
            return db.Set<T>().AsQueryable();
        }
    }


    public class CountryRepository
    {
        AppDbContext db;


        public CountryRepository()
        {
            db = new AppDbContext();
        }

        public void Add(Country model)
        {
            db.Countries.Add(model);
            db.SaveChanges();
        }

        public void Edit(Country model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public Country Find(int id)
        {
            return db.Countries.Find(id);
        }

        public IQueryable<Country> AsQueryable()
        {
            return db.Countries.AsQueryable();
        }
    }


    public class CityRepository
    {
        AppDbContext db;


        public CityRepository()
        {
            db = new AppDbContext();
        }

        public void Add(City model)
        {
            db.Cities.Add(model);
            db.SaveChanges();
        }

        public void Edit(City model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public City Find(int id)
        {
            return db.Cities.Find(id);
        }

        public IQueryable<City> AsQueryable()
        {
            return db.Cities.AsQueryable();
        }
    }


}
