﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TokenRepo : IRepository<Token, string>
    {
        HomeRentEntities db;
        public TokenRepo(HomeRentEntities db) {
            this.db = db;
        }
        public void Add(Token e)
        {
            db.Tokens.Add(e);
            db.SaveChanges();
        }

        public string ChangePass(string New_Password, int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(string token)
        {
            db.Tokens.Remove(db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token)));
            db.SaveChanges();
        }

        public void Edit(Token e)
        {
            var token = db.Tokens.FirstOrDefault(en => en.AccessToken.Equals(e.AccessToken));
            db.Entry(token).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(string token)
        {
            return db.Tokens.FirstOrDefault(e => e.AccessToken.Equals(token));
        }
        public Token Get(int id)
        {
            return db.Tokens.FirstOrDefault(e => e.UserId.Equals(id));
        }
    }
}
