using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListings.Models
{
    //Data Transafer Objects. Its a process or part of a partten of decoupling our domain objects from user interactions 
    //place validations od sanitize data before inseting them to database
    //they are like models
    //a replica of the classes or domain objects
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too long!!!")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Is Too long!!!")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int ID { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
    }
}
