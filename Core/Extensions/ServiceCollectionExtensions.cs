using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)//Bu şekilde daha sonra başka coremodule implementasyonlarını da yapabileceğiz.(this IServiceCollection serviceCollection) bu bir parametre değil neyi genişletmek istiyorsak bu şekilde yazıyoruz c# da. ICoreModule[] modules bu ise parametremiz, ıcoremodule olan bir aray veriyoruz.
        {
            foreach (var modeule in modules)
            {
                modeule.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);//Bu extensions ile ekleyeceğimiz bütün injectionları bir araya toplamış olduk.
        }
    }
}
