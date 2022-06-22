using Common.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsroAccount.Repository.Entities;

namespace Common.Models.Requests
{
    public class AddTbUserRequest: IValidation
    {
       
        public string Name { set; get; }
        public string StrUserID { set; get; }
        public string Password1 { set; get; }
        public string Password2 { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }

        public void Validate()
        {
            StrUserID.ValidationRequired("Tên đăng nhập");
            StrUserID.ValidationUsername("Tên đăng nhập", "^[a-z0-9]+$");
            StrUserID.ValidationMaxlength("Tên đăng nhập", 20);
            Password1.ValidationRequired("Mật khẩu cấp 1");
            Password2.ValidationRequired("Mật khẩu cấp 2");
            Phone.ValidationRequired("Số điện thoại");
            Phone.ValidationPhone("Số điện thoại");
            Email.ValidationRequired("Email");
            Email.ValidationEmail("Email");
            Name.ValidationRequired("Tên người dùng");
            Name.ValidationMaxlength("Tên người dùng", 50);
        }

        public TBUser MappingToTbUser()
        {
            return new TBUser()
            {
                StrUserID = StrUserID,
                Password = Password1,
                Password2 = Password2,
                Phone = Phone,
                Email = Email,
                Name = Name
            };
        }
    }
}
