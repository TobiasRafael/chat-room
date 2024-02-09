using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; }

        [Required]
        public Guid SenderId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
        public virtual ApplicationUser AppUser { get; set; }
    }
}
