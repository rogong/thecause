using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheCause.Models
{
    public class Sign
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int PetitionId { get; set; }
        [ForeignKey("PetitionId")]
        public virtual Petition Petition { get; set; }
        public string Comment { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        [Required]
        public string UpdatedAt { get; set; }
    }
}
