﻿// <auto-generated />
using System;
using CourseRegistration.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CourseRegistration.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseRegistration.Domain.FlowParticipant", b =>
                {
                    b.Property<Guid>("StateId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("uuid");

                    b.HasKey("StateId", "ParticipantId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("FlowParticipants");
                });

            modelBuilder.Entity("CourseRegistration.Domain.FlowState", b =>
                {
                    b.Property<Guid>("StateId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FlowId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RegistrationFlowId")
                        .HasColumnType("uuid");

                    b.HasKey("StateId", "FlowId");

                    b.HasIndex("FlowId");

                    b.HasIndex("RegistrationFlowId");

                    b.ToTable("FlowStates");
                });

            modelBuilder.Entity("CourseRegistration.Domain.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ExternalAccountId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("CourseRegistration.Domain.RegistrationFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("CourseRegistrationOpen")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ExternalCourseId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("RegistrationEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("RegistrationStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("CourseRegistrations");
                });

            modelBuilder.Entity("CourseRegistration.Domain.RegistrationState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("RegistrationOpen")
                        .HasColumnType("boolean");

                    b.Property<int>("VacantPositionCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("RegistrationStates");
                });

            modelBuilder.Entity("CourseRegistration.Domain.FlowParticipant", b =>
                {
                    b.HasOne("CourseRegistration.Domain.Participant", "Participant")
                        .WithMany("FlowParticipants")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistration.Domain.RegistrationState", "RegistrationState")
                        .WithMany("FlowParticipants")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("RegistrationState");
                });

            modelBuilder.Entity("CourseRegistration.Domain.FlowState", b =>
                {
                    b.HasOne("CourseRegistration.Domain.RegistrationState", "RegistrationState")
                        .WithMany("FlowStates")
                        .HasForeignKey("FlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistration.Domain.RegistrationFlow", "RegistrationFlow")
                        .WithMany("FlowStates")
                        .HasForeignKey("RegistrationFlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationFlow");

                    b.Navigation("RegistrationState");
                });

            modelBuilder.Entity("CourseRegistration.Domain.Participant", b =>
                {
                    b.Navigation("FlowParticipants");
                });

            modelBuilder.Entity("CourseRegistration.Domain.RegistrationFlow", b =>
                {
                    b.Navigation("FlowStates");
                });

            modelBuilder.Entity("CourseRegistration.Domain.RegistrationState", b =>
                {
                    b.Navigation("FlowParticipants");

                    b.Navigation("FlowStates");
                });
#pragma warning restore 612, 618
        }
    }
}
