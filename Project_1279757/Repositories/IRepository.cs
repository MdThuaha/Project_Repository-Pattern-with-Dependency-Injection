using Project_1279757.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279757.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}
