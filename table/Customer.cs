using System.ComponentModel.DataAnnotations;
namespace airline
{
    public class customer
    {
        [Key]
        public int Customer_id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Numericid { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }  

    }
    
}