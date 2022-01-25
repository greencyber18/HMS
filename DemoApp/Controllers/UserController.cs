using BEL;
using BLL;
using DemoApp.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        [CustomAuth]
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.Get());
        }
        [CustomAuth]
        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.Get(id));
        }
        [CustomAuth]
        [Route("api/users/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserModel user)
        {
            UserService.Create(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [CustomAuth]
        [Route("api/users/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(UserModel user)
        {
            UserService.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [CustomAuth]
        [Route("api/users/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [CustomAuth]
        [Route("api/flats")]
        [HttpGet]
        public HttpResponseMessage GetFlat()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlat());
        }
        [CustomAuth]
        [Route("api/flats/GetbyID/{id}")]
        [HttpGet]
        public HttpResponseMessage Getf(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlat(id));
        }
        [CustomAuth]
        [Route("api/User/GetbyID/{id}")]
        [HttpGet]
        public HttpResponseMessage GetU(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.Get(id));
        }

        [CustomAuth]

        [Route("api/flats/DHK")]
        [HttpGet]
        public HttpResponseMessage GetFlatDHK()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlatDHK());
        }
        [CustomAuth]
        [Route("api/flats/CTG")]
        [HttpGet]
        public HttpResponseMessage GetFlatCTG()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlatCTG());
        }
        [CustomAuth]
        [Route("api/flats/BAR")]
        [HttpGet]
        public HttpResponseMessage GetFlatBAR()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlatBAR());
        }
        [CustomAuth]
        [Route("api/flats/SYL")]
        [HttpGet]
        public HttpResponseMessage GetFlatSYL()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlatSYL());
        }
        [CustomAuth]
        [Route("api/flats/CLL")]
        [HttpGet]
        public HttpResponseMessage GetFlatCLL()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FlatService.GetFlatCLL());
        }



        [CustomAuth]
        public string ChangePassw(UserModel user)
        {
            return UserService.ChangePass(user.Password, user.UserId);
        }




        /* [HttpGet]
         public HttpResponseMessage GetBooking(int id)
         {
             return Request.CreateResponse(HttpStatusCode.OK, BookingService.GetBooking(id));
         } */

        [CustomAuth]
        [Route("api/Bookings/{id}")]
        [HttpGet]
        public HttpResponseMessage GetBooking(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, BookingService.GetBooking(id));
        }
        [CustomAuth]
        [Route("api/Bookings/Add")]
        [HttpPost]
        public HttpResponseMessage AddBooking(BookingModel book)
        {
            BookingService.AddBooking(book);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [CustomAuth]
        [Route("api/flats/UpdateFlat/{id}")]
        [HttpPost]
        public void UpdateStatus(int id)
        {
             FlatService.UpdateStatus(id);
        }


    }
}
