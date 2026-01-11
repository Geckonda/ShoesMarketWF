using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesMarketWF.Abstractions
{
    public interface IBaseRepository<T>
    {
        T? GetOneById(int id);
        List<T>? GetAll();
        void Update(T entity);
        void Delete(int id);
        void Add(T entity);
    }
}
