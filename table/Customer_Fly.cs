using System.ComponentModel.DataAnnotations;
namespace airline
{
    public class Customer_Fly
    {
        [Key]
        public int C_F_Id { get; set; }
        
         public int Customer_id { get; set; }
         public int Fly_Id { get; set; }
        
        

    }
    
}