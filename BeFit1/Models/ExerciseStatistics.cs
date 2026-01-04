namespace BeFit1.Models
{
    public class ExerciseStatistics
    {
        public string NazwaCwiczenia { get; set; } = string.Empty;
        public int IloscWykonan { get; set; }
        public int SumaPowtorzen { get; set; }
        public double SrednieObciazenie { get; set; }
        public int MaksymalneObciazenie { get; set; }
    }
}
