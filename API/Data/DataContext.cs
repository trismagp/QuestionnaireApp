using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
    public DbSet<Questionnaire> Questionnaires { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Questionnaire>()
        .HasOne(q => q.AppUser)
        .WithMany(u => u.Questionnaires)
        .HasForeignKey(q => q.AppUserId)
        .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<Questionnaire>()
        .HasMany(q => q.Admins)
        .WithMany(u => u.AdministeredQuestionnaires)
        .UsingEntity(j => j.ToTable("QuestionnaireAdmins"));

       modelBuilder.Entity<Questionnaire>()
        .HasMany(q => q.ParticipantList)
        .WithMany(u => u.ParticipatedQuestionnaires)
        .UsingEntity(j => j.ToTable("QuestionnaireParticipants"));  // Optional: custom table name


    
    base.OnModelCreating(modelBuilder);
}




}


