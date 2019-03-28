
using System.ComponentModel.DataAnnotations;

namespace HealthAPI.Models
{
    public class Hospital
    {
        [Key]
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }

}