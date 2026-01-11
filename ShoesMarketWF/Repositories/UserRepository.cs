using ShoesMarketWF.Abstractions;
using ShoesMarketWF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesMarketWF.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(AppDbContext db) : base(db)
        {
        }

        public UserEntity? GetOne(string username, string password)
        {
            return _db.Users.FirstOrDefault(x => x.Login == username && x.Password == password);
        }
    }
}
