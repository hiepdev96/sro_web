using Common.Generics;
using Common.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using VsroAccount.Repository;
using VsroAccount.Repository.Entities;
using VsroLog.Log_Repository;
using VsroShard.Shard_Repository;

namespace API.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class AccountController : GenericApiController
    {
        public AccountController(VsroAccountContext contextAccount, VsroLogContext contextLog, VsroShardContext contextShard) : base(contextAccount, contextLog, contextShard)
        {
        }

        [HttpPost]
        public void AddTbUser(AddTbUserRequest request)
        {
           GetService<TbUserService,VsroAccountContext>().AddTbUser(request,GetClientIp());
        }
    }
}
