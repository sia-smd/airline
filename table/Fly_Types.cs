using System;
using System.ComponentModel.DataAnnotations;
namespace airline
{
    public class Fly_Type
    {
        [Key]
       public int Type_Id { get; set; }
       public string Type_Name { get; set; }
       
    }
    
}