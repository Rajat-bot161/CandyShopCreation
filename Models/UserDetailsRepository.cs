using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserDetailsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<UserDetails> GetUserDetails
        { 
            get
            {
                return _appDbContext.UserDetail;
            }
        }

        public Boolean IsUserValid(string username,string password)
        {
            return _appDbContext.UserDetail.Any(x => x.UserName == username && x.Password == password);
        }
    }
}
