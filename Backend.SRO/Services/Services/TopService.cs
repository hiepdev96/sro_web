using Common.Enum;
using Common.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsroAccount.Repository;
using VsroAccount.Repository.Entities;
using VsroShard.Shard_Repository;
using VsroShard.Shard_Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    public class TopService : GenericService<VsroShard.Shard_Repository.Entities.Char, VsroShardContext>
    {
        private static int MAX_COUNT = 25;
        public TopService(VsroShardContext context) : base(context)
        {
        }
        public List<VsroShard.Shard_Repository.Entities.Char> GetTop(TypeTopEnum type)
        {
            List<VsroShard.Shard_Repository.Entities.Char> lst = new List<VsroShard.Shard_Repository.Entities.Char>();
            switch (type)
            {
                case TypeTopEnum.EU:
                    lst = GetTopEU();
                    break;
            }
            return lst;
            
        }

        private List<VsroShard.Shard_Repository.Entities.Char> GetTopEU()
        {
            return GetTopLvl("19");
        }

        private List<VsroShard.Shard_Repository.Entities.Char> GetTopLvl(string type)
        {
             return DbContext.Chars
                .Where(x => x.RefObjID.ToString().StartsWith(type))
                .OrderByDescending(x => x.CurLevel)
                .OrderByDescending(x => x.RemainSkillPoint)
                .Take(MAX_COUNT)
                .ToList();
            DbContext.Chars.FromSqlRaw('select top 20 * from _Char where RefObjID like {0} ')

        }
    }
}
