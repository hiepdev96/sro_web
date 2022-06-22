using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsroAccount.Repository;
using VsroLog.Log_Repository;
using VsroShard.Shard_Repository;

namespace Common.Generics
{
    public abstract class GenericApiController : ControllerBase
    {
        VsroAccountContext contextAccount;
        VsroLogContext contextLog;
        VsroShardContext contextShard;

        protected GenericApiController(VsroAccountContext contextAccount, VsroLogContext contextLog, VsroShardContext contextShard)
        {
            this.contextAccount = contextAccount;
            this.contextLog = contextLog;
            this.contextShard = contextShard;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual DbRepository<B, VsroAccountContext> GetAccountRepository<B>() where B : class
        {
            return new DbRepository<B, VsroAccountContext>(this.contextAccount);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual DbRepository<B, VsroLogContext> GetLogRepository<B>() where B : class
        {
            return new DbRepository<B, VsroLogContext>(this.contextLog);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual DbRepository<B, VsroShardContext> GetShardRepository<B>() where B : class
        {
            return new DbRepository<B, VsroShardContext>(this.contextShard);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual B GetService<B,TContext>()
        {
            return (B)typeof(B).GetConstructor(new Type[] { typeof(TContext) }).Invoke(new object[] { GetContext<TContext>() });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public string GetClientIp()
        {
            var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;
            return remoteIpAddress.ToString();
        }
        private TContext GetContext<TContext>() 
        {
            if(this.contextLog is TContext)
            {
                return (TContext)Convert.ChangeType(this.contextLog,typeof(TContext));
            }
            if (this.contextShard is TContext)
            {
                return (TContext)Convert.ChangeType(this.contextShard, typeof(TContext));
            }
            return (TContext)Convert.ChangeType(this.contextAccount, typeof(TContext));
        }

    }
}
