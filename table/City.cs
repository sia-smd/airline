using System.ComponentModel.DataAnnotations;
namespace airline
{
    public class City
    {
        [Key]
        public int city_id { get; set; }
        public string Name { get; set; }
        public string img_url { get; set; } 
    }
}