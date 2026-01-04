using System.ComponentModel.DataAnnotations;

namespace BeFit1.Models
{
    public class ExerciseType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa ćwiczenia jest wymagana")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "Nazwa musi mieć od 3 do 100 znaków")]
        public string Nazwa { get; set; } = string.Empty;
    }
}
