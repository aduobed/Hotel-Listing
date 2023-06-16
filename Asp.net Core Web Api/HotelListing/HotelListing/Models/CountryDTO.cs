using HotelListing.Data;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IEnumerable<Hotel> Hotels { get; set; } = default!;

    }

    public class CreateCountryDTO
    {
        [Required]
        [StringLength(100, ErrorMessage = "Country name is Too Long")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(2, ErrorMessage = "Country ShortName exceeds two Characters")]
        public string ShortName { get; set; } = string.Empty;
    }
}
