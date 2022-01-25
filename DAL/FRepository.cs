using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface FRepository<T, ID>
    {
        void AddFlat(T e);
        List<T> GetFlat();
        T GetFlat(ID id);
        
       
        void EditFlat(T e);
        void UpdateStatus(ID id);
        void DeleteFlat(ID id);
        List<T> GetFlatCTG();
        List<T> GetFlatDHK();
        List<T> GetFlatCLL();
        List<T> GetFlatBAR();
        List<T> GetFlatSYL();



    }
    
}
