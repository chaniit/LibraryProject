using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Dal
{
    public class UserDal
    {
        public static List<UserDto> GetAllUsers()
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {
                    List<User> user = db.Users.ToList();
                    return user.Select(x => x.ConvertToDto(x)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UserDto CheckPassword(UserDto user)
        {
            try
            {
                using (LibraryProjectEntities db = new LibraryProjectEntities())
                {
                    User u = db.Users.Where(q => q.password == user.password && q.Name_user == user.Name_user).FirstOrDefault();
                    if(u!=null)
                    return u.ConvertToDto(u);
                    return new UserDto();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static UserDto AddUser(UserDto user)
        {
            try
            {
                using(LibraryProjectEntities db=new LibraryProjectEntities())
                {
                    User u = db.Users.Add(User.ConvertToDal(user));
                    db.SaveChanges();
                    return u.ConvertToDto(u);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
