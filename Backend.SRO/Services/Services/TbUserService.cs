using Common.Exceptions;
using Common.Extentions;
using Common.Generics;
using Common.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsroAccount.Repository;
using VsroAccount.Repository.Entities;

namespace Services.Services
{
    public class TbUserService : GenericService<TBUser, VsroAccountContext>
    {
        public TbUserService(VsroAccountContext context) : base(context)
        {
        }

        public void AddTbUser(AddTbUserRequest request, string ip)
        {
            request.ValidationRequired("Tham số");
            request.TrimAllProperties();
            request?.Validate();
            CheckStrUserIdExists(request.StrUserID);
            TBUser entity = request.MappingToTbUser();
            entity.RegIp = ip;
            InsertAndSave(entity);
        }

        private void CheckStrUserIdExists(string strUserID)
        {
            if(All.Any(x => x.StrUserID == strUserID))
            {
                throw new BusinessException($"Tên đăng nhập {strUserID} đã tồn tại");
            }
        }
    }
}
