﻿using Ninject.Modules;
using NLog;
using RedisTutorial.Business.Interface;
using RedisTutorial.Business.Managers;
using RedisTutorial.Business.Managers.ServiceStack;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTutorial
{
    public class DIOperation : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICustomLogManager>().To<CustomLogManager>();
            this.Bind<IRedisNativeClient>().To<RedisClient>();
            this.Bind<IRedisClient>().To<RedisClient>();
            this.Bind<ILogger>().To<Logger>();
            this.Bind<IRedisManagerWithServiceStack>().To<RedisManagerWithServiceStack>();

        }
    }
}
