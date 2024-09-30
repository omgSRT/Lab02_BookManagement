using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class BookRequest
    {
        [Required]
        [StringLength(100)]
        public string? IBSN { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        [Required]
        [StringLength(100)]
        public string? Author { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        public int AddressId { get; set; }
        [Required]
        public int PressId { get; set; }
    }
}
