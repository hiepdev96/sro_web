using Common.Enum;
using Common.Generics;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using VsroAccount.Repository;
using VsroLog.Log_Repository;
using VsroShard.Shard_Repository;

namespace API.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class TopController : GenericApiController
    {
        public TopController(VsroAccountContext contextAccount, VsroLogContext contextLog, VsroShardContext contextShard) : base(contextAccount, contextLog, contextShard)
        {
        }

        [HttpGet]
        public List<VsroShard.Shard_Repository.Entities.Char> GetTop(TypeTopEnum type)
        {
            return GetService<TopService, VsroShardContext>().GetTop(type);
        }
    }
}
