using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = "";

        [StringLength(500)]
        public string Description { get; set; } = "";

        [Required]
        [RegularExpression("^(pending|in-progress|done)$", ErrorMessage = "Status must be: pending, in-progress, or done.")]
        public string Status { get; set; } = "pending";
    }
}
