using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SsignalRChatApp
{
    public static class IoC
    {
        public static AppDbContext AppDbContext => IocContainer.Provider.GetService<AppDbContext>();
    }


    public static class IocContainer
    {
        public static IServiceProvider Provider { get; set; }
    }
}
