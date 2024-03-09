using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);//Generic metod yazıyoruz. Biz metoda bir key veriyoruz o bize bellekten bu key e karşılık gelen veriyi verecek.
        object Get(string key);//Generic olmayan versiyon şeklinde de yazılabilir ancak burada tip dönüşümünü yani casting yapmak gerekir.
        void    Add(string key, object value, int duration);
        bool IsAdd(string key);//Cache de varmı kontrolü sağlayan metod.
        void Remove(string key);//Cache den uçurma metodu.
        void RemoveByPattern(string pattern);//Mesela başı sonu önemli değil içinde Category olanlar veya içinde Get olanaları uçur gibi.
    }
}
