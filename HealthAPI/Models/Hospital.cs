
using System.ComponentModel.DataAnnotations;

namespace HealthAPI.Models
{
    public class MedHospitalication
    {
        [Key]
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }

}