using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using t.data.EF;
using t.domain.Entities;

namespace t.app.Services
{
    public class UserService
    {
        private readonly EFDbContext _eFDbContext;

        public UserService()
        {
            _eFDbContext = new EFDbContext();
        }

        //var opcion2 = _eFDbContext.User.AsNoTracking().ToList();
        //var opcion3 = _eFDbContext.User.SqlQuery("SELECT * FROM Users").ToList();
        public List<User> Get() {
            var users = (from u in _eFDbContext.User select u).ToList();
            return users;
        }

        public User GetByID(int id) => _eFDbContext.User.FirstOrDefault(u => u.UserID == id);

        public User Create(User user)
        {
            var userResult = _eFDbContext.User.Add(User.Create(user.UserID, user.UserName, user.UserName));            
            _eFDbContext.SaveChanges();
            return userResult;
        }
    }
}
