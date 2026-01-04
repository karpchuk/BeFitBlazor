using System.ComponentModel.DataAnnotations;
using BeFit1.Data;

namespace BeFit1.Models;

public class PerformedExercise
{
    public int Id { get; set; }

    [Required]
    public int TrainingSessionId { get; set; }

    public TrainingSession? TrainingSession { get; set; }

    [Required]
    public int ExerciseTypeId { get; set; }

    public ExerciseType? ExerciseType { get; set; }

    [Range(0, 500, ErrorMessage = "Obciążenie 0–500 kg")]
    public decimal Obciazenie { get; set; }

    [Range(1, 50, ErrorMessage = "Serie 1–50")]
    public int Serie { get; set; } = 3;

    [Range(1, 200, ErrorMessage = "Powtórzenia 1–200")]
    public int Powtorzenia { get; set; } = 10;

    [Required]
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }
}
