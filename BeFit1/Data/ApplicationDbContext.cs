using BeFit1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeFit1.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<ExerciseType> ExerciseTypes => Set<ExerciseType>();
    public DbSet<TrainingSession> TrainingSessions => Set<TrainingSession>();
    public DbSet<PerformedExercise> PerformedExercises => Set<PerformedExercise>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<TrainingSession>()
      .HasOne(ts => ts.User)
      .WithMany()
      .HasForeignKey(ts => ts.UserId)
      .OnDelete(DeleteBehavior.Restrict); // ?? KLUCZOWE

        builder.Entity<PerformedExercise>()
            .HasOne(p => p.ExerciseType)
            .WithMany()
            .HasForeignKey(p => p.ExerciseTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
