using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheCause.Models
{
    public class Petition
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        [Required]
        public string UpdatedAt { get; set; }
        [Required]
        public string UserId { get; set;}
        public int NSignature { get; set; }
        public ICollection<Sign> Signs { get; set; }

        public string PhotoUrl { get; set; }
    }
}
