
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;


//Core katmanı diğer katmanları referans alma, alırsa oraya bağımlı olur.
namespace Core.DataAccsess
{
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>fliter=null);
        T Get(Expression<Func<T, bool>> fliter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId);//Kursları kategoryiye göre filtrele.
    }
}
