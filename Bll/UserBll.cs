using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
    public class UserBll
    {
        public static List<UserDto> GetAllUsers()
        {
            return UserDal.GetAllUsers();
        }

        public static UserDto AddUser(UserDto user)
        {
            return UserDal.AddUser(user);
        }

        public static UserDto CheckPassword(UserDto user)
        {
            return UserDal.CheckPassword(user);
        }
    }
}
