﻿using System;
using ServiceStack.Redis;

namespace Fm.WebCommon.WebRedis
{
    /// <summary>
    /// RedisBase类，是redis操作的基类，继承自IDisposable接口，主要用于释放内存
    /// IRedisClient为操作Redis的接口，是.Net操作Redis的主要类库，这里我们把它接入
    /// </summary>
    public abstract class RedisBase : IDisposable
    {
        public static IRedisClient Core { get; private set; }
        private bool _disposed = false;

        static RedisBase()
        {
            Core = RedisManager.GetClient();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Core.Dispose();
                    Core = null;
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 保存数据DB文件到硬盘
        /// </summary>
        public void Save()
        {
            Core.Save();
        }

        /// <summary>
        /// 异步保存数据DB文件到硬盘
        /// </summary>
        public void SaveAsync()
        {
            Core.SaveAsync();
        }
    }
}