using System.ComponentModel.DataAnnotations;
using BeFit1.Data;

namespace BeFit1.Models;

public class TrainingSession
{
    public int Id { get; set; }

    [Required]
    public DateTimeOffset Start { get; set; }

    [Required]
    public DateTimeOffset Koniec { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }
}
