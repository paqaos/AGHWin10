using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyklopediaPiwa.Interfaces.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);

        T Read(long id);

        void Update(T entity);

        void Delete(long id);

        ICollection<T> GetAll();
    }
}
