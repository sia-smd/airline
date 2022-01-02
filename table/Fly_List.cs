using System;
using System.ComponentModel.DataAnnotations;
namespace airline
{
    public class Fly_List
    {
        [Key]
       public int Fly_Id { get; set; }
       public string Airline_Name { get; set; }
       public string Source { get; set; }
       public string Destination { get; set; }
       public DateTime Date_Fly { get; set; }
       public int capcity { get; set; }
       public int Status { get; set; }
    }
    
}