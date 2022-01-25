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
   public class BookingService
    {
        static BookingService()
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


        public static List<BookingModel> GetBooking(int id)
        {
            //AutoMapper.Mapper
            var data = AutoMapper.Mapper.Map<List<BookingModel>>(DataAccessFactory.BookingDataAccess().GetBooking(id));
           
            return data;
        }

        public static void AddBooking(BookingModel booking)
        {

            var data = Mapper.Map<Booking>(booking); // for automapper 6.1.1
            DataAccessFactory.BookingDataAccess().AddBooking(data);

        }

        /*  public static BookingModel GetBooking(int id)
          {

              var data = Mapper.Map<BookingModel>(DataAccessFactory.BookingDataAccess().GetBooking(id)); // for automapper 6.1.1
              return data;
          } */
    } 
}
