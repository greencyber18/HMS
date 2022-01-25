using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class FlatService
    {
        static FlatService()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserModel>();
                cfg.CreateMap<UserModel, User>();

                cfg.CreateMap<Flat, FlatModel>();
                cfg.CreateMap<FlatModel, Flat>();

                cfg.CreateMap<Booking, BookingModel>();
                cfg.CreateMap<BookingModel, Booking>();


            });
        }


        public static List<FlatModel> GetFlat()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<FlatModel>>(DataAccessFactory.FlatDataAccess().GetFlat());
            var flat = (
                
                from f in data
                        where f.Status == "Available"
                        select f).ToList();
            return flat;
        }

        public static List<FlatModel> GetFlatDHK()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<FlatModel>>(DataAccessFactory.FlatDataAccess().GetFlatDHK());
            var flat = (

                from f in data
                where f.City == "Dhaka" && f.Status== "Available"
                select f).ToList();
            return flat;
        }



        public static List<FlatModel> GetFlatBAR()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<FlatModel>>(DataAccessFactory.FlatDataAccess().GetFlatBAR());
            var flat = (

                from f in data
                where f.City == "Barishal" && f.Status == "Available"
                select f).ToList();
            return flat;
        }

        public static List<FlatModel> GetFlatCLL()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<FlatModel>>(DataAccessFactory.FlatDataAccess().GetFlatCLL());
            var flat = (

                from f in data
                where f.City == "Comilla" && f.Status == "Available"
                select f).ToList();
            return flat;
        }

        public static List<FlatModel> GetFlatCTG()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<FlatModel>>(DataAccessFactory.FlatDataAccess().GetFlatCTG());
            var flat = (

                from f in data
                where f.City == "Chitagong" && f.Status == "Available"
                select f).ToList();
            return flat;
        }
        public static List<FlatModel> GetFlatSYL()
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<FlatModel>>(DataAccessFactory.FlatDataAccess().GetFlatSYL());
            var flat = (

                from f in data
                where f.City == "Sylhet" && f.Status == "Available"
                select f).ToList();
            return flat;
        }


        public static void UpdateStatus(int id)
        {
            DataAccessFactory.FlatDataAccess().UpdateStatus(id);
        }


        public static FlatModel GetFlat(int id)
        {

            var data = Mapper.Map<FlatModel>(DataAccessFactory.FlatDataAccess().GetFlat(id)); // for automapper 6.1.1
            return data;
        }

    }
}
