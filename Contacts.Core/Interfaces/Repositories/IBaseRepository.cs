using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> ListAll();
        int SaveChanges();

    }
}
