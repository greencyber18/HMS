using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FlatRepo : FRepository<Flat, int>
    {

        HomeRentEntities db;
        public FlatRepo(HomeRentEntities db)
        {
            this.db = db;
        }
        public void AddFlat(Flat e)
        {
            db.Flats.Add(e);
            db.SaveChanges();
        }

        public void DeleteFlat(int id)
        {
            var fl = db.Flats.FirstOrDefault(p => p.FlatId == id);
            db.Flats.Remove(fl);
            db.SaveChanges();
        }

        public void EditFlat(Flat e)
        {
            throw new NotImplementedException();
        }

        public List<Flat> GetFlat()
        {

            return db.Flats.ToList();
        }


        public List<Flat> GetFlatDHK()
        {

            return db.Flats.ToList();
        }
        public List<Flat> GetFlatCTG()
        {

            return db.Flats.ToList();
        }
        public List<Flat> GetFlatBAR()
        {

            return db.Flats.ToList();
        }
        public List<Flat> GetFlatCLL()
        {

            return db.Flats.ToList();
        }
        public List<Flat> GetFlatSYL()
        {

            return db.Flats.ToList();
        }

        public Flat GetFlat(int id)
        {
            var flat = (from f in db.Flats
                        where f.FlatId == id 
                        select f).First();
            return flat;
        }

        public void UpdateStatus(int ID)
        {
            var flat = (from f in db.Flats
                        where f.FlatId == ID
                        select f).First();
            flat.Status = "Processing";
            db.SaveChanges();
        }

      
    }

}
