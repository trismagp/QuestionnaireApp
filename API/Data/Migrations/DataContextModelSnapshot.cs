﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("API.Entities.AnswerOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("AnswerOption");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Interests")
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("KnownAs")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<string>("LookingFor")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("QuestionSectionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionSectionId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("API.Entities.QuestionSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("QuestionnaireId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("QuestionSection");
                });

            modelBuilder.Entity("API.Entities.Questionnaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Questionnaires");
                });

            modelBuilder.Entity("AppUserQuestionnaire", b =>
                {
                    b.Property<int>("AdministeredQuestionnairesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdministeredQuestionnairesId", "AdminsId");

                    b.HasIndex("AdminsId");

                    b.ToTable("QuestionnaireAdmins", (string)null);
                });

            modelBuilder.Entity("AppUserQuestionnaire1", b =>
                {
                    b.Property<int>("ParticipantListId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParticipatedQuestionnairesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ParticipantListId", "ParticipatedQuestionnairesId");

                    b.HasIndex("ParticipatedQuestionnairesId");

                    b.ToTable("QuestionnaireParticipants", (string)null);
                });

            modelBuilder.Entity("API.Entities.AnswerOption", b =>
                {
                    b.HasOne("API.Entities.Question", null)
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.Question", b =>
                {
                    b.HasOne("API.Entities.QuestionSection", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuestionSectionId");
                });

            modelBuilder.Entity("API.Entities.QuestionSection", b =>
                {
                    b.HasOne("API.Entities.Questionnaire", null)
                        .WithMany("Sections")
                        .HasForeignKey("QuestionnaireId");
                });

            modelBuilder.Entity("API.Entities.Questionnaire", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Questionnaires")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("AppUserQuestionnaire", b =>
                {
                    b.HasOne("API.Entities.Questionnaire", null)
                        .WithMany()
                        .HasForeignKey("AdministeredQuestionnairesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("AdminsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppUserQuestionnaire1", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("ParticipantListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Questionnaire", null)
                        .WithMany()
                        .HasForeignKey("ParticipatedQuestionnairesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Questionnaires");
                });

            modelBuilder.Entity("API.Entities.Question", b =>
                {
                    b.Navigation("AnswerOptions");
                });

            modelBuilder.Entity("API.Entities.QuestionSection", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("API.Entities.Questionnaire", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
