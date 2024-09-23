using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Press
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PressId { get; set; }
        [Required]
        [StringLength(100)]
        public string? PressName { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        [JsonIgnore]
        public virtual ICollection<Book>? Books { get; set; }
    }
}
