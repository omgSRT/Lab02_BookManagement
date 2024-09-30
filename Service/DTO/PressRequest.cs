using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class PressRequest
    {
        [Required]
        [StringLength(100)]
        public string? PressName { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
