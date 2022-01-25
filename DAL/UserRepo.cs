using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo : IRepository<User, int>,IAuth
    {
        HomeRentEntities db;
        public UserRepo(HomeRentEntities db) {
            this.db = db;
        }
        public void Add(User e)
        {
            
         
           
            e.active = 1;
           
            e.Type = 3;
            db.Users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Users.Remove(db.Users.FirstOrDefault(e => e.UserId == id));
            db.SaveChanges();
        }

        public void Edit(User e)
        {
            User us = (from ur in db.Users
                       where ur.UserId == e.UserId
                       select ur).FirstOrDefault();

            us.Username = e.Username;
            us.Email = e.Email;
            us.Password = e.Password;
            us.Address = e.Address;
            db.SaveChanges();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
           
                var user = (from f in db.Users
                            where f.UserId == id
                            select f).First();
                return user;
            
        }
        public User GetName(string name)
        {
            return db.Users.FirstOrDefault(e => e.Username == name);
        }
        public Token Authenticate(User user)
        {
            var u = db.Users.FirstOrDefault(en => en.Email.Equals(user.Email) && en.Password.Equals(user.Password));
            Token t = null;
            if(u != null) //authenticated
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.UserId = u.UserId;
                t.AccessToken = token;
              
                t.CreatedAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();

            }
            return t;
        }

      


        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.AccessToken.Equals(token) && e.ExpiredAt == null);
            return rs;
        }
        public bool Logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
            if(t != null)
            {
                t.ExpiredAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;

        }


        public string ChangePass(string New_Password, int id)
        {
            var currPass = (from p in db.Users
                            where p.UserId == id
                            select p.Password).FirstOrDefault();

            if (currPass == New_Password)
            {
                return "This password alerady exits";
            }
            else
            {
                User us = (from ur in db.Users
                           where ur.UserId == id
                           select ur).FirstOrDefault();
                us.Password = New_Password;
                db.SaveChanges();
                return "Password change Successfully";
            }
        }
    }
}
