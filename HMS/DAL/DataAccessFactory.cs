using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static HomeRentEntities db;
        static DataAccessFactory()
        {
            db = new HomeRentEntities();
        }
       
        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(db);
        }
        public static IAuth AuthDataAccess() {
            return new UserRepo(db);
        }
    }
}
