using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace To_Do_List.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Task completed")]
        public bool IsCompleted { get; set; }
        [Required, MaxLength(50)]
        [DisplayName("Title")]
        public string? TaskTitle { get; set; }

        [DisplayName("Description"), MaxLength(500)]
        public string? Description {  get; set; }

        public DateTime TimeTaskCreated { get; set; }
        public DateTime TimeTaskCompleted { get; set; }
    }
}
