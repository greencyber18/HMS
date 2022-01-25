using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
    public class UserService
    {
        static UserService() {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserModel>();
                cfg.CreateMap<UserModel, User>();

                cfg.CreateMap<Flat, FlatModel>();
                cfg.CreateMap<FlatModel, Flat>();
                

            });
        }
        public static List<UserModel> Get()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<UserModel>>(DataAccessFactory.UserDataAccess().Get()); // for automapper 6.1.1
            return data;
        }
        public static UserModel Get(int id)
        {
            
            var data = Mapper.Map<UserModel>(DataAccessFactory.UserDataAccess().Get(id)); // for automapper 6.1.1
            return data;
        }


        public static void Create(UserModel user)
        {
            
            var data = Mapper.Map<User>(user); // for automapper 6.1.1
            DataAccessFactory.UserDataAccess().Add(data);

        }
        public static void Edit(UserModel user)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<UserModel, Token>());
            var data = Mapper.Map<User>(user); // for automapper 6.1.1
            DataAccessFactory.UserDataAccess().Edit(data);

        }
        public static void Delete(int id)
        {
            DataAccessFactory.UserDataAccess().Delete(id);
        }

        public static string ChangePass(string newPass, int id)
        {
            //var config = new MapperConfiguration(ct => ct.CreateMap<UsersModel, User>());
            //var mapper = new Mapper(config);
            //var data = mapper.Map<UsersModel>(DataAccessFactory.UserDataAccess().ChangePassword(currPass, newPass, id));
            //return data;

            var data = DataAccessFactory.UserDataAccess().ChangePass(newPass, id);
            return data;
        }




    }
}
