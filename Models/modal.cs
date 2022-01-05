using System;
using System.Linq;
using System.Collections.Generic;

namespace airline
{
    public class vm_air_list
    {
       public int Fly_Id { get; set; }
       public string Airline_Name { get; set; }
       public string SourceCity_name { get; set; }
       public string DestinationCity_name { get; set; }
       public DateTime Date_Fly { get; set; }
       public int capcity { get; set; }
       
    }

    public class F_List
    {
        public readonly connect _conect;
        public F_List(connect connect)
        {
            _conect=connect;
        }
        public void select()
        {
            
           var list= (from fl in _conect.Fly_Lists
                 join c in _conect.Citys on c.city_id equals fl.SourceCity_id
                 join c1 in _conect.Citys on c1.city_id equals fl.DestinationCity_id
                 select new {
                   Flyid=fl.Fly_Id,        
                   Fly_name=fl.Airline_Name,
                   SourceCity=c.Name,
                   DestinyCity=c1.Name,
                   FLY_Date= fl.Date_Fly,
                   Capcity=fl.capcity
                 });
            //return list;
        }
    }
}