using HotelListing.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Models
{
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; } = default!;
    }

    public class CreateHotelDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "Hotel name is Too Long")]
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        [Required]
        [Range(0, 5)]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
