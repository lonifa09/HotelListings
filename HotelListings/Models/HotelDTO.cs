using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListings.Models
{
    public class CreateHotelDTO
    {
        //Data Transafer Objects. Its a process or part of a partten of decoupling our domain objects from user interactions 
        //place validations od sanitize data before inseting them to database
        //they are like models
        //a replica of the classes or domain objects
        //DTOs talk to DTOs not to classes or domain objects
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel Name Is Too long!!!")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Country Name Is Too long!!!")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
    public class HotelDTO: CreateHotelDTO
    {
        public int ID { get; set; }
        public CountryDTO Country { get; set; }
    }

}
