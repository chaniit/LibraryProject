using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public partial class User
    {
        public UserDto ConvertToDto(User user)
        {
            UserDto userDto = new UserDto();
            userDto.Id = user.Id;
            userDto.Name_user = user.Name_user;
            userDto.password = user.password;
            userDto.phone = user.phone;
            userDto.email = user.email;
            return userDto;
        }
        public static User ConvertToDal(UserDto userDto)
        {
            User user = new User();
            user.Id = userDto.Id;
            user.Name_user = userDto.Name_user;
            user.password = userDto.password;
            user.phone = userDto.phone;
            user.email = userDto.email;
            return user;
        }
    }
}
