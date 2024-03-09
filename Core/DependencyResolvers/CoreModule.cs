using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();//Bunu eklediğimiz zaman MemoryCacheManager daki IMemoryCache _memoryCache; in bir karşılı olmuş oluyor.
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//???
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();//Daha sonra sistemi Rdis'e geçirmek istediğimizde Redis klasöründeki gerekli kodları yazıp RedisCacheManager yazmamız yeterli.
        }
    }
}
